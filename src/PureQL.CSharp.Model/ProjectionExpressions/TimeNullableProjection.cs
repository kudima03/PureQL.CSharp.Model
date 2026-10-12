using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class TimeNullableProjection
    : OneOfBase<TimeProjection, ExactTimeNullableProjection>
{
    public TimeNullableProjection(TimeProjection value)
        : this((OneOf<TimeProjection, ExactTimeNullableProjection>)value) { }

    public TimeNullableProjection(ExactTimeNullableProjection value)
        : this((OneOf<TimeProjection, ExactTimeNullableProjection>)value) { }

    private TimeNullableProjection(
        OneOf<TimeProjection, ExactTimeNullableProjection> input
    )
        : base(input) { }
}
