using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyStringNullable : IKey
{
    public KeyStringNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeStringNullable();
}
