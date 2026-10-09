using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ConditionalIntegerProjection
    : OneOfBase<IfIntegerProjection, CoalesceIntegerProjection>
{
    public ConditionalIntegerProjection(IfIntegerProjection value)
        : this((OneOf<IfIntegerProjection, CoalesceIntegerProjection>)value) { }

    public ConditionalIntegerProjection(CoalesceIntegerProjection value)
        : this((OneOf<IfIntegerProjection, CoalesceIntegerProjection>)value) { }

    private ConditionalIntegerProjection(
        OneOf<IfIntegerProjection, CoalesceIntegerProjection> input
    )
        : base(input) { }
}
