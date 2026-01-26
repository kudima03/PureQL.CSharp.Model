using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class DateArrayReturning
    : OneOfBase<DateArrayParameter, DateField, DateArrayScalar>
{
    public DateArrayReturning(DateArrayParameter parameter)
        : this((OneOf<DateArrayParameter, DateField, DateArrayScalar>)parameter) { }

    public DateArrayReturning(DateField field)
        : this((OneOf<DateArrayParameter, DateField, DateArrayScalar>)field) { }

    public DateArrayReturning(DateArrayScalar scalar)
        : this((OneOf<DateArrayParameter, DateField, DateArrayScalar>)scalar) { }

    private DateArrayReturning(
        OneOf<DateArrayParameter, DateField, DateArrayScalar> input
    )
        : base(input) { }
}
