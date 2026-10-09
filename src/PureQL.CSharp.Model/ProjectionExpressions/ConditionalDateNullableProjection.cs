using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDateNullableProjection
    : OneOfBase<IfDateNullableProjection, CoalesceDateNullableProjection>
{
    public ConditionalDateNullableProjection(IfDateNullableProjection value)
        : this((OneOf<IfDateNullableProjection, CoalesceDateNullableProjection>)value) { }

    public ConditionalDateNullableProjection(CoalesceDateNullableProjection value)
        : this((OneOf<IfDateNullableProjection, CoalesceDateNullableProjection>)value) { }

    private ConditionalDateNullableProjection(
        OneOf<IfDateNullableProjection, CoalesceDateNullableProjection> input
    )
        : base(input) { }
}
