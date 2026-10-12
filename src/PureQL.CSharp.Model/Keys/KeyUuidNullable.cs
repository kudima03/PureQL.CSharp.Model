using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyUuidNullable : IKey
{
    public KeyUuidNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeUuidNullable();
}
