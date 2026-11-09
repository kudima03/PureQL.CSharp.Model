namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.decimal</c>.</summary>
public sealed record TypeDecimal : IType
{
    public string Name => "decimal";

    public bool Nullable => false;
}
