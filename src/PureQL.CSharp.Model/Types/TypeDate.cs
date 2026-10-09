namespace PureQL.CSharp.Model.Types;

public sealed record TypeDate : IType
{
    public string Name => "date";

    public bool Nullable => false;
}
