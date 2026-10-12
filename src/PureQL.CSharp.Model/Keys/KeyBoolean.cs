using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyBoolean : IKey
{
    public KeyBoolean(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeBoolean();
}
