using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Date;

public sealed record MinDate
{
    public MinDate(DateArrayReturning argument)
    {
        Argument = argument;
    }

    public DateArrayReturning Argument { get; }
}
