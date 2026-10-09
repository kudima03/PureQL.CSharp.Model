using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyInteger : IKey
{
    public KeyInteger(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeInteger();
}
