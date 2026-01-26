using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class DateTimeReturning : OneOfBase<DateTimeParameter, DateTimeScalar>
{
    public DateTimeReturning(DateTimeParameter parameter)
        : this((OneOf<DateTimeParameter, DateTimeScalar>)parameter) { }

    public DateTimeReturning(DateTimeScalar scalar)
        : this((OneOf<DateTimeParameter, DateTimeScalar>)scalar) { }

    private DateTimeReturning(OneOf<DateTimeParameter, DateTimeScalar> input)
        : base(input) { }
}
