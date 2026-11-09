using System.Collections;
using System.Globalization;
using System.Text;
using System.Text.Json;

namespace PureQL.CSharp.Model.Generator;

/// <summary>
/// A JSON object that keeps its keys in insertion order. Assigning an existing key keeps
/// its position, as in JavaScript, so the normalizer reads like its TypeScript original.
/// Values are <see cref="JsonMap"/>, <see cref="List{T}"/> of values, <see cref="string"/>,
/// <see cref="double"/>, <see cref="bool"/> or <see langword="null"/>.
/// </summary>
internal sealed class JsonMap : IEnumerable<KeyValuePair<string, object?>>
{
    private readonly List<string> _keys = [];
    private readonly Dictionary<string, object?> _values = [];

    public JsonMap() { }

    public JsonMap(IEnumerable<KeyValuePair<string, object?>> entries)
    {
        foreach (KeyValuePair<string, object?> entry in entries)
        {
            this[entry.Key] = entry.Value;
        }
    }

    public IReadOnlyList<string> Keys => _keys;

    public IEnumerable<object?> Values => _keys.Select(key => _values[key]);

    public int Count => _keys.Count;

    public object? this[string key]
    {
        get => _values.GetValueOrDefault(key);
        set
        {
            if (!_values.ContainsKey(key))
            {
                _keys.Add(key);
            }
            _values[key] = value;
        }
    }

    public void Add(KeyValuePair<string, object?> entry)
    {
        this[entry.Key] = entry.Value;
    }

    public bool Has(string key)
    {
        return _values.ContainsKey(key);
    }

    /// <summary>A shallow copy without <paramref name="keys"/>.</summary>
    public JsonMap Without(params string[] keys)
    {
        return [.. this.Where(entry => !keys.Contains(entry.Key))];
    }

    /// <summary>A shallow copy with the entries of <paramref name="other"/> assigned.</summary>
    public JsonMap With(JsonMap other)
    {
        JsonMap result = [.. this];
        foreach (KeyValuePair<string, object?> entry in other)
        {
            result[entry.Key] = entry.Value;
        }
        return result;
    }

    public IEnumerator<KeyValuePair<string, object?>> GetEnumerator()
    {
        return _keys
            .Select(key => new KeyValuePair<string, object?>(key, _values[key]))
            .GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

internal static class Json
{
    public static object? Parse(string text)
    {
        using JsonDocument document = JsonDocument.Parse(text);
        return Read(document.RootElement);
    }

    private static object? Read(JsonElement element)
    {
        return element.ValueKind switch
        {
            JsonValueKind.Object => new JsonMap(
                element
                    .EnumerateObject()
                    .Select(p => new KeyValuePair<string, object?>(p.Name, Read(p.Value)))
            ),
            JsonValueKind.Array => element.EnumerateArray().Select(Read).ToList(),
            JsonValueKind.String => element.GetString(),
            JsonValueKind.Number => element.GetDouble(),
            JsonValueKind.True => true,
            JsonValueKind.False => false,
            JsonValueKind.Null => null,
            JsonValueKind.Undefined or _ => throw new InvalidOperationException(
                $"Unsupported JSON value {element.ValueKind}"
            ),
        };
    }

    /// <summary>Compact JSON, for error messages and for comparing schemas.</summary>
    public static string Write(object? value)
    {
        StringBuilder builder = new StringBuilder();
        Write(value, builder);
        return builder.ToString();
    }

    private static void Write(object? value, StringBuilder builder)
    {
        switch (value)
        {
            case JsonMap map:
                _ = builder.Append('{');
                bool firstKey = true;
                foreach (KeyValuePair<string, object?> entry in map)
                {
                    _ = builder.Append(firstKey ? "" : ",");
                    firstKey = false;
                    _ = builder.Append(JsonSerializer.Serialize(entry.Key)).Append(':');
                    Write(entry.Value, builder);
                }
                _ = builder.Append('}');
                break;
            case List<object?> list:
                _ = builder.Append('[');
                for (int i = 0; i < list.Count; i++)
                {
                    _ = builder.Append(i == 0 ? "" : ",");
                    Write(list[i], builder);
                }
                _ = builder.Append(']');
                break;
            case string text:
                _ = builder.Append(JsonSerializer.Serialize(text));
                break;
            case double number:
                _ = builder.Append(number.ToString("R", CultureInfo.InvariantCulture));
                break;
            case bool flag:
                _ = builder.Append(flag ? "true" : "false");
                break;
            case null:
                _ = builder.Append("null");
                break;
            default:
                throw new InvalidOperationException(
                    $"Unsupported value {value.GetType()}"
                );
        }
    }
}
