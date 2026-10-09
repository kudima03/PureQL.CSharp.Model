namespace PureQL.CSharp.Model.Types;

public sealed record TypeDatetime : IType
{
    public string Name => "datetime";

    public bool Nullable => false;
}
