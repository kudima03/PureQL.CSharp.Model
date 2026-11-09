using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.time.nullable</c>.</summary>
public sealed record KeyTimeNullable : IKey
{
    public KeyTimeNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeTimeNullable();
}
