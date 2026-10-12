using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DecimalProjection
    : OneOfBase<ExactDecimalProjection, IntegerProjection>
{
    public DecimalProjection(ExactDecimalProjection value)
        : this((OneOf<ExactDecimalProjection, IntegerProjection>)value) { }

    public DecimalProjection(IntegerProjection value)
        : this((OneOf<ExactDecimalProjection, IntegerProjection>)value) { }

    private DecimalProjection(OneOf<ExactDecimalProjection, IntegerProjection> input)
        : base(input) { }
}
