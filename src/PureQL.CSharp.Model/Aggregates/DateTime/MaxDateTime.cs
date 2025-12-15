using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record MaxDateTime
{
    public MaxDateTime(DateTimeReturning argument)
    {
        Argument = argument;
    }

    public DateTimeReturning Argument { get; }
}
