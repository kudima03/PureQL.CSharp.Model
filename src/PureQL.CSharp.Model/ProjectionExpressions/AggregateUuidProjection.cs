using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateUuidProjection
    : OneOfBase<MinUuidProjection, MaxUuidProjection>
{
    public AggregateUuidProjection(MinUuidProjection value)
        : this((OneOf<MinUuidProjection, MaxUuidProjection>)value) { }

    public AggregateUuidProjection(MaxUuidProjection value)
        : this((OneOf<MinUuidProjection, MaxUuidProjection>)value) { }

    private AggregateUuidProjection(OneOf<MinUuidProjection, MaxUuidProjection> input)
        : base(input) { }
}
