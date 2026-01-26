using OneOf;
using PureQL.CSharp.Model.Parameters;
using PureQL.CSharp.Model.Scalars;

namespace PureQL.CSharp.Model.Returnings;

public sealed class TimeReturning : OneOfBase<TimeParameter, TimeScalar>
{
    public TimeReturning(TimeParameter parameter)
        : this((OneOf<TimeParameter, TimeScalar>)parameter) { }

    public TimeReturning(TimeScalar scalar)
        : this((OneOf<TimeParameter, TimeScalar>)scalar) { }

    private TimeReturning(OneOf<TimeParameter, TimeScalar> input)
        : base(input) { }
}
