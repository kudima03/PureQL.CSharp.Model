namespace PureQL.CSharp.Model.Types;

public sealed record TypeDecimalNullable : IType
{
    public string Name => "decimal";

    public bool Nullable => true;
}
