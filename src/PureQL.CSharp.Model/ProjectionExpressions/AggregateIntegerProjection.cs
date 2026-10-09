using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class AggregateIntegerProjection
    : OneOfBase<CountProjection, SumIntegerProjection>
{
    public AggregateIntegerProjection(CountProjection value)
        : this((OneOf<CountProjection, SumIntegerProjection>)value) { }

    public AggregateIntegerProjection(SumIntegerProjection value)
        : this((OneOf<CountProjection, SumIntegerProjection>)value) { }

    private AggregateIntegerProjection(OneOf<CountProjection, SumIntegerProjection> input)
        : base(input) { }
}
