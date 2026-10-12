using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyInteger : IKey
{
    public KeyInteger(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeInteger();
}
