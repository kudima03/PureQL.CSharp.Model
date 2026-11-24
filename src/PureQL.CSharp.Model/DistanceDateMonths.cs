namespace PureQL.CSharp.Model;

public sealed record DistanceDateMonths
{
    public DistanceDateMonths(DistanceDateMonthsMonths months)
    {
        Months = months;
    }

    public DistanceDateMonthsMonths Months { get; }
}
