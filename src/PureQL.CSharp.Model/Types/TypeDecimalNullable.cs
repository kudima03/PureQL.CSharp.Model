namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.decimal.nullable</c>.</summary>
public sealed record TypeDecimalNullable : IType
{
    public string Name => "decimal";

    public bool Nullable => true;
}
