using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class TimeReturning : OneOfBase<TimeField, TimeParameter, TimeScalar>
{
    public TimeReturning(TimeField field)
        : this((OneOf<TimeField, TimeParameter, TimeScalar>)field) { }

    public TimeReturning(TimeParameter parameter)
        : this((OneOf<TimeField, TimeParameter, TimeScalar>)parameter) { }

    public TimeReturning(TimeScalar scalar)
        : this((OneOf<TimeField, TimeParameter, TimeScalar>)scalar) { }

    private TimeReturning(OneOf<TimeField, TimeParameter, TimeScalar> input)
        : base(input) { }
}
