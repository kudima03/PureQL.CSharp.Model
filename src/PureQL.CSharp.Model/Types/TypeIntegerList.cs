namespace PureQL.CSharp.Model.Types;

public sealed record TypeIntegerList : IType
{
    public string Name => "integerList";

    public bool Nullable => false;
}
