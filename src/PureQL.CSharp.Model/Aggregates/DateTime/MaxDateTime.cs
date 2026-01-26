using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record MaxDateTime
{
    public MaxDateTime(DateTimeArrayReturning argument)
    {
        Argument = argument;
    }

    public DateTimeArrayReturning Argument { get; }
}
