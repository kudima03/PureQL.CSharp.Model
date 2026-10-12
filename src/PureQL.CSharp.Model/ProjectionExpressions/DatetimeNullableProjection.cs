using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DatetimeNullableProjection
    : OneOfBase<DatetimeProjection, ExactDatetimeNullableProjection>
{
    public DatetimeNullableProjection(DatetimeProjection value)
        : this((OneOf<DatetimeProjection, ExactDatetimeNullableProjection>)value) { }

    public DatetimeNullableProjection(ExactDatetimeNullableProjection value)
        : this((OneOf<DatetimeProjection, ExactDatetimeNullableProjection>)value) { }

    private DatetimeNullableProjection(
        OneOf<DatetimeProjection, ExactDatetimeNullableProjection> input
    )
        : base(input) { }
}
