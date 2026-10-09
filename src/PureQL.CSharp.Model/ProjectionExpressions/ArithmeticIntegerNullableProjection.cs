using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class ArithmeticIntegerNullableProjection
    : OneOfBase<
        AddIntegerNullableProjection,
        SubtractIntegerNullableProjection,
        MultiplyIntegerNullableProjection,
        IntegerDivideIntegerNullableProjection,
        ModuloIntegerNullableProjection
    >
{
    public ArithmeticIntegerNullableProjection(AddIntegerNullableProjection value)
        : this(
            (OneOf<
                AddIntegerNullableProjection,
                SubtractIntegerNullableProjection,
                MultiplyIntegerNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableProjection(SubtractIntegerNullableProjection value)
        : this(
            (OneOf<
                AddIntegerNullableProjection,
                SubtractIntegerNullableProjection,
                MultiplyIntegerNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableProjection(MultiplyIntegerNullableProjection value)
        : this(
            (OneOf<
                AddIntegerNullableProjection,
                SubtractIntegerNullableProjection,
                MultiplyIntegerNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableProjection(
        IntegerDivideIntegerNullableProjection value
    )
        : this(
            (OneOf<
                AddIntegerNullableProjection,
                SubtractIntegerNullableProjection,
                MultiplyIntegerNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableProjection(ModuloIntegerNullableProjection value)
        : this(
            (OneOf<
                AddIntegerNullableProjection,
                SubtractIntegerNullableProjection,
                MultiplyIntegerNullableProjection,
                IntegerDivideIntegerNullableProjection,
                ModuloIntegerNullableProjection
            >)
                value
        )
    { }

    private ArithmeticIntegerNullableProjection(
        OneOf<
            AddIntegerNullableProjection,
            SubtractIntegerNullableProjection,
            MultiplyIntegerNullableProjection,
            IntegerDivideIntegerNullableProjection,
            ModuloIntegerNullableProjection
        > input
    )
        : base(input) { }
}
