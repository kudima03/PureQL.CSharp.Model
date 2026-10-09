using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateBooleanProjection : OneOfBase<AnyProjection, AllProjection>
{
    public AggregateBooleanProjection(AnyProjection value)
        : this((OneOf<AnyProjection, AllProjection>)value) { }

    public AggregateBooleanProjection(AllProjection value)
        : this((OneOf<AnyProjection, AllProjection>)value) { }

    private AggregateBooleanProjection(OneOf<AnyProjection, AllProjection> input)
        : base(input) { }
}
