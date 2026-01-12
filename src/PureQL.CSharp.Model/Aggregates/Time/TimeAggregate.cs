using OneOf;
using PureQL.CSharp.Model.Aggregates.Date;

namespace PureQL.CSharp.Model.Aggregates.Time;

public sealed class TimeAggregate : OneOfBase<MaxTime, MinTime, AveradeTime>
{
    public TimeAggregate(AveradeTime averageTime)
        : this((OneOf<MaxTime, MinTime, AveradeTime>)averageTime) { }

    public TimeAggregate(MinTime minTime)
        : this((OneOf<MaxTime, MinTime, AveradeTime>)minTime) { }

    public TimeAggregate(MaxTime maxTime)
        : this((OneOf<MaxTime, MinTime, AveradeTime>)maxTime) { }

    private TimeAggregate(OneOf<MaxTime, MinTime, AveradeTime> input)
        : base(input) { }
}
