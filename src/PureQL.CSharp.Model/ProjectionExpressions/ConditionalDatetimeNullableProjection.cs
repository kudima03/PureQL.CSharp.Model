using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDatetimeNullableProjection
    : OneOfBase<IfDatetimeNullableProjection, CoalesceDatetimeNullableProjection>
{
    public ConditionalDatetimeNullableProjection(IfDatetimeNullableProjection value)
        : this(
            (OneOf<IfDatetimeNullableProjection, CoalesceDatetimeNullableProjection>)value
        )
    { }

    public ConditionalDatetimeNullableProjection(CoalesceDatetimeNullableProjection value)
        : this(
            (OneOf<IfDatetimeNullableProjection, CoalesceDatetimeNullableProjection>)value
        )
    { }

    private ConditionalDatetimeNullableProjection(
        OneOf<IfDatetimeNullableProjection, CoalesceDatetimeNullableProjection> input
    )
        : base(input) { }
}
