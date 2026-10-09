namespace PureQL.CSharp.Model.Types;

public sealed record TypeStringNullable : IType
{
    public string Name => "string";

    public bool Nullable => true;
}
