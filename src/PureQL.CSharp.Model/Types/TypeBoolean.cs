namespace PureQL.CSharp.Model.Types;

public sealed record TypeBoolean : IType
{
    public string Name => "boolean";

    public bool Nullable => false;
}
