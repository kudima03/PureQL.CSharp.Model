namespace PureQL.CSharp.Model.Types;

public sealed record TypeString : IType
{
    public string Name => "string";

    public bool Nullable => false;
}
