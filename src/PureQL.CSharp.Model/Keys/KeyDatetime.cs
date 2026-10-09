using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDatetime : IKey
{
    public KeyDatetime(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDatetime();
}
