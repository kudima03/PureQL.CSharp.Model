using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyStringNullable : IKey
{
    public KeyStringNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeStringNullable();
}
