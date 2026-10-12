using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class DecimalNullableTotal
    : OneOfBase<
        ExactDecimalTotal,
        ExactDecimalNullableTotal,
        IntegerTotal,
        ExactIntegerNullableTotal
    >
{
    public DecimalNullableTotal(ExactDecimalTotal value)
        : this(
            (OneOf<
                ExactDecimalTotal,
                ExactDecimalNullableTotal,
                IntegerTotal,
                ExactIntegerNullableTotal
            >)
                value
        )
    { }

    public DecimalNullableTotal(ExactDecimalNullableTotal value)
        : this(
            (OneOf<
                ExactDecimalTotal,
                ExactDecimalNullableTotal,
                IntegerTotal,
                ExactIntegerNullableTotal
            >)
                value
        )
    { }

    public DecimalNullableTotal(IntegerTotal value)
        : this(
            (OneOf<
                ExactDecimalTotal,
                ExactDecimalNullableTotal,
                IntegerTotal,
                ExactIntegerNullableTotal
            >)
                value
        )
    { }

    public DecimalNullableTotal(ExactIntegerNullableTotal value)
        : this(
            (OneOf<
                ExactDecimalTotal,
                ExactDecimalNullableTotal,
                IntegerTotal,
                ExactIntegerNullableTotal
            >)
                value
        )
    { }

    private DecimalNullableTotal(
        OneOf<
            ExactDecimalTotal,
            ExactDecimalNullableTotal,
            IntegerTotal,
            ExactIntegerNullableTotal
        > input
    )
        : base(input) { }
}
