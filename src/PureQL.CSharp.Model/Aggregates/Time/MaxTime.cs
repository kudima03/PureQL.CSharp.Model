using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record MaxTime
{
    public MaxTime(TimeArrayReturning argument)
    {
        Argument = argument;
    }

    public TimeArrayReturning Argument { get; }
}
