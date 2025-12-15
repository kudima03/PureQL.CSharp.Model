using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record AverageDate
{
    public AverageDate(DateReturning argument)
    {
        Argument = argument;
    }

    public DateReturning Argument { get; }
}
