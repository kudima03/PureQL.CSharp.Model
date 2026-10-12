using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDatetimeNullable : IKey
{
    public KeyDatetimeNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDatetimeNullable();
}
