using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record AverageDateTime
{
    public AverageDateTime(DateTimeArrayReturning argument)
    {
        Argument = argument;
    }

    public DateTimeArrayReturning Argument { get; }
}
