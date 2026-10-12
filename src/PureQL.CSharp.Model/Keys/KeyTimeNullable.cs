using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyTimeNullable : IKey
{
    public KeyTimeNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeTimeNullable();
}
