namespace PureQL.CSharp.Model.Types;

public sealed record TypeTimeList : IType
{
    public string Name => "timeList";

    public bool Nullable => false;
}
