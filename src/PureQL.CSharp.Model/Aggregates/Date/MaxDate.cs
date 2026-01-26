using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record MaxDate
{
    public MaxDate(DateArrayReturning argument)
    {
        Argument = argument;
    }

    public DateArrayReturning Argument { get; }
}
