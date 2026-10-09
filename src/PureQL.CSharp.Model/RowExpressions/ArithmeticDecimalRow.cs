using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticDecimalRow
    : OneOfBase<
        AddDecimalRow,
        SubtractDecimalRow,
        MultiplyDecimalRow,
        DivideDecimalRow,
        IntegerDivideIntegerRow,
        ModuloIntegerRow
    >
{
    public ArithmeticDecimalRow(AddDecimalRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticDecimalRow(SubtractDecimalRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticDecimalRow(MultiplyDecimalRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticDecimalRow(DivideDecimalRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticDecimalRow(IntegerDivideIntegerRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticDecimalRow(ModuloIntegerRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    private ArithmeticDecimalRow(
        OneOf<
            AddDecimalRow,
            SubtractDecimalRow,
            MultiplyDecimalRow,
            DivideDecimalRow,
            IntegerDivideIntegerRow,
            ModuloIntegerRow
        > input
    )
        : base(input) { }
}
