using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class DecimalNullableProjection
    : OneOfBase<
        ExactDecimalProjection,
        ExactDecimalNullableProjection,
        IntegerProjection,
        ExactIntegerNullableProjection
    >
{
    public DecimalNullableProjection(ExactDecimalProjection value)
        : this(
            (OneOf<
                ExactDecimalProjection,
                ExactDecimalNullableProjection,
                IntegerProjection,
                ExactIntegerNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(ExactDecimalNullableProjection value)
        : this(
            (OneOf<
                ExactDecimalProjection,
                ExactDecimalNullableProjection,
                IntegerProjection,
                ExactIntegerNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(IntegerProjection value)
        : this(
            (OneOf<
                ExactDecimalProjection,
                ExactDecimalNullableProjection,
                IntegerProjection,
                ExactIntegerNullableProjection
            >)
                value
        )
    { }

    public DecimalNullableProjection(ExactIntegerNullableProjection value)
        : this(
            (OneOf<
                ExactDecimalProjection,
                ExactDecimalNullableProjection,
                IntegerProjection,
                ExactIntegerNullableProjection
            >)
                value
        )
    { }

    private DecimalNullableProjection(
        OneOf<
            ExactDecimalProjection,
            ExactDecimalNullableProjection,
            IntegerProjection,
            ExactIntegerNullableProjection
        > input
    )
        : base(input) { }
}
