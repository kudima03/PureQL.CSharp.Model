using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyUuid : IKey
{
    public KeyUuid(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeUuid();
}
