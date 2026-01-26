using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record AverageDate
{
    public AverageDate(DateArrayReturning argument)
    {
        Argument = argument;
    }

    public DateArrayReturning Argument { get; }
}
