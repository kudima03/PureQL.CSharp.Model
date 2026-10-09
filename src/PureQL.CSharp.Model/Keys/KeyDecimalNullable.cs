using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDecimalNullable : IKey
{
    public KeyDecimalNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDecimalNullable();
}
