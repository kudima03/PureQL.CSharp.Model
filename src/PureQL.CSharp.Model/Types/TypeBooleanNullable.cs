namespace PureQL.CSharp.Model.Types;

public sealed record TypeBooleanNullable : IType
{
    public string Name => "boolean";

    public bool Nullable => true;
}
