using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDecimal : IKey
{
    public KeyDecimal(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDecimal();
}
