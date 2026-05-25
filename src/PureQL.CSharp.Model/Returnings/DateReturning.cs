using OneOf;
using PureQL.CSharp.Model.Aggregates.Date;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateReturning : OneOfBase<DateParameter, DateScalar, DateAggregate>
{
    public DateReturning(DateParameter parameter)
        : this((OneOf<DateParameter, DateScalar, DateAggregate>)parameter) { }

    public DateReturning(DateScalar scalar)
        : this((OneOf<DateParameter, DateScalar, DateAggregate>)scalar) { }

    public DateReturning(DateAggregate aggregate)
        : this((OneOf<DateParameter, DateScalar, DateAggregate>)aggregate) { }

    private DateReturning(OneOf<DateParameter, DateScalar, DateAggregate> input)
        : base(input) { }
}
