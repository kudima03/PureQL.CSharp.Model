using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record MaxTime
{
    public MaxTime(TimeReturning argument)
    {
        Argument = argument;
    }

    public TimeReturning Argument { get; }
}
