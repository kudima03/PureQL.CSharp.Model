using PureQL.CSharp.Model.ArrayReturnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record AverageTime
{
    public AverageTime(TimeArrayReturning argument)
    {
        Argument = argument;
    }

    public TimeArrayReturning Argument { get; }
}
