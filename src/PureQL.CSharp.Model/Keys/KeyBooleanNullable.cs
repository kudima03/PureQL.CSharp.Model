using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyBooleanNullable : IKey
{
    public KeyBooleanNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeBooleanNullable();
}
