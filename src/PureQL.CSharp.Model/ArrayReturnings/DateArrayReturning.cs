using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachDateArithmetics;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class DateArrayReturning
    : OneOfBase<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays>
{
    public DateArrayReturning(DateArrayParameter parameter)
        : this(
            (OneOf<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays>)parameter
        )
    { }

    public DateArrayReturning(DateField field)
        : this((OneOf<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays>)field) { }

    public DateArrayReturning(DateArrayScalar scalar)
        : this(
            (OneOf<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays>)scalar
        )
    { }

    public DateArrayReturning(EachDateAddDays addDays)
        : this(
            (OneOf<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays>)addDays
        )
    { }

    private DateArrayReturning(
        OneOf<DateArrayParameter, DateField, DateArrayScalar, EachDateAddDays> input
    )
        : base(input) { }
}
