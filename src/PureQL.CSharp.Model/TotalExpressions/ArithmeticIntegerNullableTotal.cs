using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ArithmeticIntegerNullableTotal
    : OneOfBase<
        AddIntegerNullableTotal,
        SubtractIntegerNullableTotal,
        MultiplyIntegerNullableTotal,
        IntegerDivideIntegerNullableTotal,
        ModuloIntegerNullableTotal
    >
{
    public ArithmeticIntegerNullableTotal(AddIntegerNullableTotal value)
        : this(
            (OneOf<
                AddIntegerNullableTotal,
                SubtractIntegerNullableTotal,
                MultiplyIntegerNullableTotal,
                IntegerDivideIntegerNullableTotal,
                ModuloIntegerNullableTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableTotal(SubtractIntegerNullableTotal value)
        : this(
            (OneOf<
                AddIntegerNullableTotal,
                SubtractIntegerNullableTotal,
                MultiplyIntegerNullableTotal,
                IntegerDivideIntegerNullableTotal,
                ModuloIntegerNullableTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableTotal(MultiplyIntegerNullableTotal value)
        : this(
            (OneOf<
                AddIntegerNullableTotal,
                SubtractIntegerNullableTotal,
                MultiplyIntegerNullableTotal,
                IntegerDivideIntegerNullableTotal,
                ModuloIntegerNullableTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableTotal(IntegerDivideIntegerNullableTotal value)
        : this(
            (OneOf<
                AddIntegerNullableTotal,
                SubtractIntegerNullableTotal,
                MultiplyIntegerNullableTotal,
                IntegerDivideIntegerNullableTotal,
                ModuloIntegerNullableTotal
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableTotal(ModuloIntegerNullableTotal value)
        : this(
            (OneOf<
                AddIntegerNullableTotal,
                SubtractIntegerNullableTotal,
                MultiplyIntegerNullableTotal,
                IntegerDivideIntegerNullableTotal,
                ModuloIntegerNullableTotal
            >)
                value
        )
    { }

    private ArithmeticIntegerNullableTotal(
        OneOf<
            AddIntegerNullableTotal,
            SubtractIntegerNullableTotal,
            MultiplyIntegerNullableTotal,
            IntegerDivideIntegerNullableTotal,
            ModuloIntegerNullableTotal
        > input
    )
        : base(input) { }
}
