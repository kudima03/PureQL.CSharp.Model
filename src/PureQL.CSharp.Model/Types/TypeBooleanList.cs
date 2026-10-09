namespace PureQL.CSharp.Model.Types;

public sealed record TypeBooleanList : IType
{
    public string Name => "booleanList";

    public bool Nullable => false;
}
