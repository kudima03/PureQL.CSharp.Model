using OneOf;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed class TimeAggregate : OneOfBase<MaxTime, MinTime, AverageTime>
{
    public TimeAggregate(AverageTime averageTime)
        : this((OneOf<MaxTime, MinTime, AverageTime>)averageTime) { }

    public TimeAggregate(MinTime minTime)
        : this((OneOf<MaxTime, MinTime, AverageTime>)minTime) { }

    public TimeAggregate(MaxTime maxTime)
        : this((OneOf<MaxTime, MinTime, AverageTime>)maxTime) { }

    private TimeAggregate(OneOf<MaxTime, MinTime, AverageTime> input)
        : base(input) { }
}
