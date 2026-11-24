namespace PureQL.CSharp.Model;

public sealed record DistanceDateDays
{
    public DistanceDateDays(DistanceDateDaysDays days)
    {
        Days = days;
    }

    public DistanceDateDaysDays Days { get; }
}
