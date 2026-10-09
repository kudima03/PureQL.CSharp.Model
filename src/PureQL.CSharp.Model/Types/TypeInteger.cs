namespace PureQL.CSharp.Model.Types;

public sealed record TypeInteger : IType
{
    public string Name => "integer";

    public bool Nullable => false;
}
