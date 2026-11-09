using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Keys;

/// <summary>PureQL <c>key.decimal.nullable</c>.</summary>
public sealed record KeyDecimalNullable : IKey
{
    public KeyDecimalNullable(string key)
    {
        Key = key;
    }

    public string Key { get; }

    public IType Type => new TypeDecimalNullable();
}
