using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticDecimalNullableProjection
    : OneOfBase<
        AddDecimalNullableProjection,
        SubtractDecimalNullableProjection,
        MultiplyDecimalNullableProjection,
        DivideDecimalNullableProjection
    >
{
    public ArithmeticDecimalNullableProjection(AddDecimalNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableProjection(SubtractDecimalNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableProjection(MultiplyDecimalNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableProjection(DivideDecimalNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableProjection(
        OneOf<
            AddDecimalNullableProjection,
            SubtractDecimalNullableProjection,
            MultiplyDecimalNullableProjection,
            DivideDecimalNullableProjection
        > input
    )
        : base(input) { }
}
