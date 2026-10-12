using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class TimeNullableTotal : OneOfBase<TimeTotal, ExactTimeNullableTotal>
{
    public TimeNullableTotal(TimeTotal value)
        : this((OneOf<TimeTotal, ExactTimeNullableTotal>)value) { }

    public TimeNullableTotal(ExactTimeNullableTotal value)
        : this((OneOf<TimeTotal, ExactTimeNullableTotal>)value) { }

    private TimeNullableTotal(OneOf<TimeTotal, ExactTimeNullableTotal> input)
        : base(input) { }
}
