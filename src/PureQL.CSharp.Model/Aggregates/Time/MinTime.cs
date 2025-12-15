using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed record MinTime
{
    public MinTime(TimeReturning argument)
    {
        Argument = argument;
    }

    public TimeReturning Argument { get; }
}
