using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalDateProjection
    : OneOfBase<IfDateProjection, CoalesceDateProjection>
{
    public ConditionalDateProjection(IfDateProjection value)
        : this((OneOf<IfDateProjection, CoalesceDateProjection>)value) { }

    public ConditionalDateProjection(CoalesceDateProjection value)
        : this((OneOf<IfDateProjection, CoalesceDateProjection>)value) { }

    private ConditionalDateProjection(
        OneOf<IfDateProjection, CoalesceDateProjection> input
    )
        : base(input) { }
}
