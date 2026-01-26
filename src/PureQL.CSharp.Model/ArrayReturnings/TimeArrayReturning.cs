using OneOf;
using PureQL.CSharp.Model.ArrayParameters;
using PureQL.CSharp.Model.ArrayScalars;
using PureQL.CSharp.Model.Fields;

namespace PureQL.CSharp.Model.ArrayReturnings;

public sealed class TimeArrayReturning
    : OneOfBase<TimeArrayParameter, TimeField, TimeArrayScalar>
{
    public TimeArrayReturning(TimeArrayParameter parameter)
        : this((OneOf<TimeArrayParameter, TimeField, TimeArrayScalar>)parameter) { }

    public TimeArrayReturning(TimeField field)
        : this((OneOf<TimeArrayParameter, TimeField, TimeArrayScalar>)field) { }

    public TimeArrayReturning(TimeArrayScalar scalar)
        : this((OneOf<TimeArrayParameter, TimeField, TimeArrayScalar>)scalar) { }

    private TimeArrayReturning(
        OneOf<TimeArrayParameter, TimeField, TimeArrayScalar> input
    )
        : base(input) { }
}
