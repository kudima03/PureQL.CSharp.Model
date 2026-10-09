using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyTime : IKey
{
    public KeyTime(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeTime();
}
