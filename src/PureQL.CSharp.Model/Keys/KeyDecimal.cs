using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDecimal : IKey
{
    public KeyDecimal(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDecimal();
}
