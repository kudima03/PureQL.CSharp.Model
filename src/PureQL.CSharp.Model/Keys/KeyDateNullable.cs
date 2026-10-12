using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyDateNullable : IKey
{
    public KeyDateNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDateNullable();
}
