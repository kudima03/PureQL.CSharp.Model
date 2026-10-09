using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticDecimalNullableRow
    : OneOfBase<
        AddDecimalNullableRow,
        SubtractDecimalNullableRow,
        MultiplyDecimalNullableRow,
        DivideDecimalNullableRow,
        IntegerDivideIntegerNullableRow,
        ModuloIntegerNullableRow
    >
{
    public ArithmeticDecimalNullableRow(AddDecimalNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableRow(SubtractDecimalNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableRow(MultiplyDecimalNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableRow(DivideDecimalNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableRow(IntegerDivideIntegerNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableRow(ModuloIntegerNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow,
                IntegerDivideIntegerNullableRow,
                ModuloIntegerNullableRow
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableRow(
        OneOf<
            AddDecimalNullableRow,
            SubtractDecimalNullableRow,
            MultiplyDecimalNullableRow,
            DivideDecimalNullableRow,
            IntegerDivideIntegerNullableRow,
            ModuloIntegerNullableRow
        > input
    )
        : base(input) { }
}
