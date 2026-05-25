using OneOf;
using PureQL.CSharp.Model.Aggregates.Time;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class TimeReturning : OneOfBase<TimeParameter, TimeScalar, TimeAggregate>
{
    public TimeReturning(TimeParameter parameter)
        : this((OneOf<TimeParameter, TimeScalar, TimeAggregate>)parameter) { }

    public TimeReturning(TimeScalar scalar)
        : this((OneOf<TimeParameter, TimeScalar, TimeAggregate>)scalar) { }

    public TimeReturning(TimeAggregate aggregate)
        : this((OneOf<TimeParameter, TimeScalar, TimeAggregate>)aggregate) { }

    private TimeReturning(OneOf<TimeParameter, TimeScalar, TimeAggregate> input)
        : base(input) { }
}
