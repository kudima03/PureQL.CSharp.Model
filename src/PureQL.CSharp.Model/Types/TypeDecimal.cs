namespace PureQL.CSharp.Model.Types;

public sealed record TypeDecimal : IType
{
    public string Name => "decimal";

    public bool Nullable => false;
}
