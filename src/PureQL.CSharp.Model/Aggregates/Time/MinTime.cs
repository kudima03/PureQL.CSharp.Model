using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record MinTime
{
    public MinTime(TimeArrayReturning argument)
    {
        Argument = argument;
    }

    public TimeArrayReturning Argument { get; }
}
