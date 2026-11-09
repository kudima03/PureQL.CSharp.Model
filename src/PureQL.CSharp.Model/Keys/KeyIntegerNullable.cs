using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.integer.nullable</c>.</summary>
public sealed record KeyIntegerNullable : IKey
{
    public KeyIntegerNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeIntegerNullable();
}
