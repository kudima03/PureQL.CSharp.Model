using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachDateTimeArithmetics;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class DateTimeArrayReturning
    : OneOfBase<
        DateTimeArrayParameter,
        DateTimeField,
        DateTimeArrayScalar,
        EachDateTimeAddSeconds
    >
{
    public DateTimeArrayReturning(DateTimeArrayParameter parameter)
        : this(
            (OneOf<
                DateTimeArrayParameter,
                DateTimeField,
                DateTimeArrayScalar,
                EachDateTimeAddSeconds
            >)
                parameter
        )
    { }

    public DateTimeArrayReturning(DateTimeField field)
        : this(
            (OneOf<
                DateTimeArrayParameter,
                DateTimeField,
                DateTimeArrayScalar,
                EachDateTimeAddSeconds
            >)
                field
        )
    { }

    public DateTimeArrayReturning(DateTimeArrayScalar scalar)
        : this(
            (OneOf<
                DateTimeArrayParameter,
                DateTimeField,
                DateTimeArrayScalar,
                EachDateTimeAddSeconds
            >)
                scalar
        )
    { }

    public DateTimeArrayReturning(EachDateTimeAddSeconds addSeconds)
        : this(
            (OneOf<
                DateTimeArrayParameter,
                DateTimeField,
                DateTimeArrayScalar,
                EachDateTimeAddSeconds
            >)
                addSeconds
        )
    { }

    private DateTimeArrayReturning(
        OneOf<
            DateTimeArrayParameter,
            DateTimeField,
            DateTimeArrayScalar,
            EachDateTimeAddSeconds
        > input
    )
        : base(input) { }
}
