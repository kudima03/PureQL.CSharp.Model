using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.DateTime;

public sealed record MinDateTime
{
    public MinDateTime(DateTimeReturning argument)
    {
        Argument = argument;
    }

    public DateTimeReturning Argument { get; }
}
