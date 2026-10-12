using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticDecimalRow
    : OneOfBase<AddDecimalRow, SubtractDecimalRow, MultiplyDecimalRow, DivideDecimalRow>
{
    public ArithmeticDecimalRow(AddDecimalRow value)
        : this(
            (OneOf<
                AddDecimalRow,
                SubtractDecimalRow,
                MultiplyDecimalRow,
                DivideDecimalRow
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
                DivideDecimalRow
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
                DivideDecimalRow
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
                DivideDecimalRow
            >)
                value
        )
    { }

    private ArithmeticDecimalRow(
        OneOf<
            AddDecimalRow,
            SubtractDecimalRow,
            MultiplyDecimalRow,
            DivideDecimalRow
        > input
    )
        : base(input) { }
}
