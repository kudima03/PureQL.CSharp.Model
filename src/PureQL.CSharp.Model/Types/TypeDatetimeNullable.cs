namespace PureQL.CSharp.Model.Types;

public sealed record TypeDatetimeNullable : IType
{
    public string Name => "datetime";

    public bool Nullable => true;
}
