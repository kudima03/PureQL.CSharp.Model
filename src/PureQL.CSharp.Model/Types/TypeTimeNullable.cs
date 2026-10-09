namespace PureQL.CSharp.Model.Types;

public sealed record TypeTimeNullable : IType
{
    public string Name => "time";

    public bool Nullable => true;
}
