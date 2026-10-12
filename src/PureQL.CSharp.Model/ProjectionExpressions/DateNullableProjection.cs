using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DateNullableProjection
    : OneOfBase<DateProjection, ExactDateNullableProjection>
{
    public DateNullableProjection(DateProjection value)
        : this((OneOf<DateProjection, ExactDateNullableProjection>)value) { }

    public DateNullableProjection(ExactDateNullableProjection value)
        : this((OneOf<DateProjection, ExactDateNullableProjection>)value) { }

    private DateNullableProjection(
        OneOf<DateProjection, ExactDateNullableProjection> input
    )
        : base(input) { }
}
