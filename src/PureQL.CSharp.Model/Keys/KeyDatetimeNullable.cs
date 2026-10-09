using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDatetimeNullable : IKey
{
    public KeyDatetimeNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDatetimeNullable();
}
