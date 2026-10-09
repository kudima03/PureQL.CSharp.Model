namespace PureQL.CSharp.Model.Types;

public sealed record TypeTime : IType
{
    public string Name => "time";

    public bool Nullable => false;
}
