using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

public sealed record KeyBooleanNullable : IKey
{
    public KeyBooleanNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeBooleanNullable();
}
