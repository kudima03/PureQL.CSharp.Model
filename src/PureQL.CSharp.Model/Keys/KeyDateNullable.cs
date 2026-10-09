using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDateNullable : IKey
{
    public KeyDateNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeDateNullable();
}
