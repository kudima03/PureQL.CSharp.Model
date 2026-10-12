using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ArithmeticDecimalNullableRow
    : OneOfBase<
        AddDecimalNullableRow,
        SubtractDecimalNullableRow,
        MultiplyDecimalNullableRow,
        DivideDecimalNullableRow
    >
{
    public ArithmeticDecimalNullableRow(AddDecimalNullableRow value)
        : this(
            (OneOf<
                AddDecimalNullableRow,
                SubtractDecimalNullableRow,
                MultiplyDecimalNullableRow,
                DivideDecimalNullableRow
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
                DivideDecimalNullableRow
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
                DivideDecimalNullableRow
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
                DivideDecimalNullableRow
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableRow(
        OneOf<
            AddDecimalNullableRow,
            SubtractDecimalNullableRow,
            MultiplyDecimalNullableRow,
            DivideDecimalNullableRow
        > input
    )
        : base(input) { }
}
