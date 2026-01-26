using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record MinDateTime
{
    public MinDateTime(DateTimeArrayReturning argument)
    {
        Argument = argument;
    }

    public DateTimeArrayReturning Argument { get; }
}
