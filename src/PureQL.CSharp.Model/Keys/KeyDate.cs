using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDate : IKey
{
    public KeyDate(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDate();
}
