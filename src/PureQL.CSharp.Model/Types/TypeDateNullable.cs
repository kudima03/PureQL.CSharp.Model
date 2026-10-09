namespace PureQL.CSharp.Model.Types;

public sealed record TypeDateNullable : IType
{
    public string Name => "date";

    public bool Nullable => true;
}
