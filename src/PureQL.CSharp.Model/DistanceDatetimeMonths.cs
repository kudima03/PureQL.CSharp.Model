namespace PureQL.CSharp.Model;

public sealed record DistanceDatetimeMonths
{
    public DistanceDatetimeMonths(DistanceDatetimeMonthsMonths months)
    {
        Months = months;
    }

    public DistanceDatetimeMonthsMonths Months { get; }
}
