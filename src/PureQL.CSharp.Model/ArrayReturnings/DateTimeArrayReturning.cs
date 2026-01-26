using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class DateTimeArrayReturning
    : OneOfBase<DateTimeArrayParameter, DateTimeField, DateTimeArrayScalar>
{
    public DateTimeArrayReturning(DateTimeArrayParameter parameter)
        : this(
            (OneOf<DateTimeArrayParameter, DateTimeField, DateTimeArrayScalar>)parameter
        )
    { }

    public DateTimeArrayReturning(DateTimeField field)
        : this((OneOf<DateTimeArrayParameter, DateTimeField, DateTimeArrayScalar>)field)
    { }

    public DateTimeArrayReturning(DateTimeArrayScalar scalar)
        : this((OneOf<DateTimeArrayParameter, DateTimeField, DateTimeArrayScalar>)scalar)
    { }

    private DateTimeArrayReturning(
        OneOf<DateTimeArrayParameter, DateTimeField, DateTimeArrayScalar> input
    )
        : base(input) { }
}
