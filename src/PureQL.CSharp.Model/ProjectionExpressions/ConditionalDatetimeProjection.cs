using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDatetimeProjection
    : OneOfBase<IfDatetimeProjection, CoalesceDatetimeProjection>
{
    public ConditionalDatetimeProjection(IfDatetimeProjection value)
        : this((OneOf<IfDatetimeProjection, CoalesceDatetimeProjection>)value) { }

    public ConditionalDatetimeProjection(CoalesceDatetimeProjection value)
        : this((OneOf<IfDatetimeProjection, CoalesceDatetimeProjection>)value) { }

    private ConditionalDatetimeProjection(
        OneOf<IfDatetimeProjection, CoalesceDatetimeProjection> input
    )
        : base(input) { }
}
