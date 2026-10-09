using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticIntegerNullableRow
    : OneOfBase<
        AddIntegerNullableRow,
        SubtractIntegerNullableRow,
        MultiplyIntegerNullableRow,
        IntegerDivideIntegerNullableRow,
        ModuloIntegerNullableRow
    >
{
    public ArithmeticIntegerNullableRow(AddIntegerNullableRow value)
        : this(
            (OneOf<
                AddIntegerNullableRow,
                SubtractIntegerNullableRow,
                MultiplyIntegerNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableRow(SubtractIntegerNullableRow value)
        : this(
            (OneOf<
                AddIntegerNullableRow,
                SubtractIntegerNullableRow,
                MultiplyIntegerNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableRow(MultiplyIntegerNullableRow value)
        : this(
            (OneOf<
                AddIntegerNullableRow,
                SubtractIntegerNullableRow,
                MultiplyIntegerNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableRow(IntegerDivideIntegerNullableRow value)
        : this(
            (OneOf<
                AddIntegerNullableRow,
                SubtractIntegerNullableRow,
                MultiplyIntegerNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticIntegerNullableRow(ModuloIntegerNullableRow value)
        : this(
            (OneOf<
                AddIntegerNullableRow,
                SubtractIntegerNullableRow,
                MultiplyIntegerNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    private ArithmeticIntegerNullableRow(
        OneOf<
            AddIntegerNullableRow,
            SubtractIntegerNullableRow,
            MultiplyIntegerNullableRow,
            IntegerDivideIntegerNullableRow,
            ModuloIntegerNullableRow
        > input
    )
        : base(input) { }
}
