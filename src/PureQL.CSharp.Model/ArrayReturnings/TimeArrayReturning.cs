using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.EachTimeArithmetics;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class TimeArrayReturning
    : OneOfBase<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds>
{
    public TimeArrayReturning(TimeArrayParameter parameter)
        : this(
            (OneOf<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds>)
                parameter
        )
    { }

    public TimeArrayReturning(TimeField field)
        : this(
            (OneOf<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds>)
                field
        )
    { }

    public TimeArrayReturning(TimeArrayScalar scalar)
        : this(
            (OneOf<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds>)
                scalar
        )
    { }

    public TimeArrayReturning(EachTimeAddSeconds addSeconds)
        : this(
            (OneOf<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds>)
                addSeconds
        )
    { }

    private TimeArrayReturning(
        OneOf<TimeArrayParameter, TimeField, TimeArrayScalar, EachTimeAddSeconds> input
    )
        : base(input) { }
}
