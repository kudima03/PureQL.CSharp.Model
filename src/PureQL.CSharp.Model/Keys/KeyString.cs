using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyString : IKey
{
    public KeyString(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeString();
}
