using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticDecimalNullableProjection
    : OneOfBase<
        AddDecimalNullableProjection,
        SubtractDecimalNullableProjection,
        MultiplyDecimalNullableProjection,
        DivideDecimalNullableProjection,
        IntegerDivideIntegerNullableProjection,
        ModuloIntegerNullableProjection
    >
{
    public ArithmeticDecimalNullableProjection(AddDecimalNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
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
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
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
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
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
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableProjection(
        IntegerDivideIntegerNullableProjection value
    )
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableProjection(ModuloIntegerNullableProjection value)
        : this(
            (OneOf<
                AddDecimalNullableProjection,
                SubtractDecimalNullableProjection,
                MultiplyDecimalNullableProjection,
                DivideDecimalNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableProjection(
        OneOf<
            AddDecimalNullableProjection,
            SubtractDecimalNullableProjection,
            MultiplyDecimalNullableProjection,
            DivideDecimalNullableProjection,
            IntegerDivideIntegerNullableProjection,
            ModuloIntegerNullableProjection
        > input
    )
        : base(input) { }
}
