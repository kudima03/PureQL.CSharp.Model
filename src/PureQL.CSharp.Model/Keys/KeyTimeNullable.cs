using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyTimeNullable : IKey
{
    public KeyTimeNullable(int key)
    {
        Key = key;
    }

    public int Key { get; }

    public IType Type => new TypeTimeNullable();
}
