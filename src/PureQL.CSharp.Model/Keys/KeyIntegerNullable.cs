using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyIntegerNullable : IKey
{
    public KeyIntegerNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeIntegerNullable();
}
