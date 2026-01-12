using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record AverageTime
{
    public AverageTime(TimeReturning argument)
    {
        Argument = argument;
    }

    public TimeReturning Argument { get; }
}
