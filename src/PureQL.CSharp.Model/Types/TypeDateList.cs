namespace PureQL.CSharp.Model.Types;

public sealed record TypeDateList : IType
{
    public string Name => "dateList";

    public bool Nullable => false;
}
