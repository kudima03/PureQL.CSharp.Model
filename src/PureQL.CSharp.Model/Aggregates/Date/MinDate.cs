using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record MinDate
{
    public MinDate(DateReturning argument)
    {
        Argument = argument;
    }

    public DateReturning Argument { get; }
}
