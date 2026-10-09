using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyBoolean : IKey
{
    public KeyBoolean(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeBoolean();
}
