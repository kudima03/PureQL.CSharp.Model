using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record AverageDateTime
{
    public AverageDateTime(DateTimeReturning argument)
    {
        Argument = argument;
    }

    public DateTimeReturning Argument { get; }
}
