using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticIntegerRow
    : OneOfBase<
        AddIntegerRow,
        SubtractIntegerRow,
        MultiplyIntegerRow,
        IntegerDivideIntegerRow,
        ModuloIntegerRow
    >
{
    public ArithmeticIntegerRow(AddIntegerRow value)
        : this(
            (OneOf<
                AddIntegerRow,
                SubtractIntegerRow,
                MultiplyIntegerRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticIntegerRow(SubtractIntegerRow value)
        : this(
            (OneOf<
                AddIntegerRow,
                SubtractIntegerRow,
                MultiplyIntegerRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticIntegerRow(MultiplyIntegerRow value)
        : this(
            (OneOf<
                AddIntegerRow,
                SubtractIntegerRow,
                MultiplyIntegerRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticIntegerRow(IntegerDivideIntegerRow value)
        : this(
            (OneOf<
                AddIntegerRow,
                SubtractIntegerRow,
                MultiplyIntegerRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    public ArithmeticIntegerRow(ModuloIntegerRow value)
        : this(
            (OneOf<
                AddIntegerRow,
                SubtractIntegerRow,
                MultiplyIntegerRow,
                IntegerDivideIntegerRow,
                ModuloIntegerRow
            >)
                value
        )
    { }

    private ArithmeticIntegerRow(
        OneOf<
            AddIntegerRow,
            SubtractIntegerRow,
            MultiplyIntegerRow,
            IntegerDivideIntegerRow,
            ModuloIntegerRow
        > input
    )
        : base(input) { }
}
