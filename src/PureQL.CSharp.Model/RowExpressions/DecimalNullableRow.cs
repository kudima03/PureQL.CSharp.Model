using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DecimalNullableRow
    : OneOfBase<
        ExactDecimalRow,
        ExactDecimalNullableRow,
        IntegerRow,
        ExactIntegerNullableRow
    >
{
    public DecimalNullableRow(ExactDecimalRow value)
        : this(
            (OneOf<
                ExactDecimalRow,
                ExactDecimalNullableRow,
                IntegerRow,
                ExactIntegerNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(ExactDecimalNullableRow value)
        : this(
            (OneOf<
                ExactDecimalRow,
                ExactDecimalNullableRow,
                IntegerRow,
                ExactIntegerNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(IntegerRow value)
        : this(
            (OneOf<
                ExactDecimalRow,
                ExactDecimalNullableRow,
                IntegerRow,
                ExactIntegerNullableRow
            >)
                value
        )
    { }

    public DecimalNullableRow(ExactIntegerNullableRow value)
        : this(
            (OneOf<
                ExactDecimalRow,
                ExactDecimalNullableRow,
                IntegerRow,
                ExactIntegerNullableRow
            >)
                value
        )
    { }

    private DecimalNullableRow(
        OneOf<
            ExactDecimalRow,
            ExactDecimalNullableRow,
            IntegerRow,
            ExactIntegerNullableRow
        > input
    )
        : base(input) { }
}
