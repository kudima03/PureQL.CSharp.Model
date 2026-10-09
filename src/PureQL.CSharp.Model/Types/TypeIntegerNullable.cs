namespace PureQL.CSharp.Model.Types;

public sealed record TypeIntegerNullable : IType
{
    public string Name => "integer";

    public bool Nullable => true;
}
