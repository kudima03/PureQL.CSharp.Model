using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateTimeReturning
    : OneOfBase<DateTimeField, DateTimeParameter, DateTimeScalar>
{
    public DateTimeReturning(DateTimeField field)
        : this((OneOf<DateTimeField, DateTimeParameter, DateTimeScalar>)field) { }

    public DateTimeReturning(DateTimeParameter parameter)
        : this((OneOf<DateTimeField, DateTimeParameter, DateTimeScalar>)parameter) { }

    public DateTimeReturning(DateTimeScalar scalar)
        : this((OneOf<DateTimeField, DateTimeParameter, DateTimeScalar>)scalar) { }

    private DateTimeReturning(
        OneOf<DateTimeField, DateTimeParameter, DateTimeScalar> input
    )
        : base(input) { }
}
