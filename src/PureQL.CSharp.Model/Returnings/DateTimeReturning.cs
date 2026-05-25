using OneOf;
using PureQL.CSharp.Model.Aggregates.DateTime;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateTimeReturning
    : OneOfBase<DateTimeParameter, DateTimeScalar, DateTimeAggregate>
{
    public DateTimeReturning(DateTimeParameter parameter)
        : this((OneOf<DateTimeParameter, DateTimeScalar, DateTimeAggregate>)parameter) { }

    public DateTimeReturning(DateTimeScalar scalar)
        : this((OneOf<DateTimeParameter, DateTimeScalar, DateTimeAggregate>)scalar) { }

    public DateTimeReturning(DateTimeAggregate aggregate)
        : this((OneOf<DateTimeParameter, DateTimeScalar, DateTimeAggregate>)aggregate) { }

    private DateTimeReturning(
        OneOf<DateTimeParameter, DateTimeScalar, DateTimeAggregate> input
    )
        : base(input) { }
}
