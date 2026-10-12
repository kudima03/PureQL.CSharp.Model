using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyUuid : IKey
{
    public KeyUuid(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeUuid();
}
