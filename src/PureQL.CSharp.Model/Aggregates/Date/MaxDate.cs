using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record MaxDate
{
    public MaxDate(DateReturning argument)
    {
        Argument = argument;
    }

    public DateReturning Argument { get; }
}
