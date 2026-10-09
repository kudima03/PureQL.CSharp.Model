using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyUuidNullable : IKey
{
    public KeyUuidNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeUuidNullable();
}
