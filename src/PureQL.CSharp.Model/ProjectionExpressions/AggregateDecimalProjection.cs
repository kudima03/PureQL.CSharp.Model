using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateDecimalProjection
    : OneOfBase<CountProjection, SumDecimalProjection>
{
    public AggregateDecimalProjection(CountProjection value)
        : this((OneOf<CountProjection, SumDecimalProjection>)value) { }

    public AggregateDecimalProjection(SumDecimalProjection value)
        : this((OneOf<CountProjection, SumDecimalProjection>)value) { }

    private AggregateDecimalProjection(OneOf<CountProjection, SumDecimalProjection> input)
        : base(input) { }
}
