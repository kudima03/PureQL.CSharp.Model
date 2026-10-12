using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class IntegerNullableProjection
    : OneOfBase<IntegerProjection, ExactIntegerNullableProjection>
{
    public IntegerNullableProjection(IntegerProjection value)
        : this((OneOf<IntegerProjection, ExactIntegerNullableProjection>)value) { }

    public IntegerNullableProjection(ExactIntegerNullableProjection value)
        : this((OneOf<IntegerProjection, ExactIntegerNullableProjection>)value) { }

    private IntegerNullableProjection(
        OneOf<IntegerProjection, ExactIntegerNullableProjection> input
    )
        : base(input) { }
}
