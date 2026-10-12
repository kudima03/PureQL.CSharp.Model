using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ArithmeticDecimalNullableTotal
    : OneOfBase<
        AddDecimalNullableTotal,
        SubtractDecimalNullableTotal,
        MultiplyDecimalNullableTotal,
        DivideDecimalNullableTotal
    >
{
    public ArithmeticDecimalNullableTotal(AddDecimalNullableTotal value)
        : this(
            (OneOf<
                AddDecimalNullableTotal,
                SubtractDecimalNullableTotal,
                MultiplyDecimalNullableTotal,
                DivideDecimalNullableTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableTotal(SubtractDecimalNullableTotal value)
        : this(
            (OneOf<
                AddDecimalNullableTotal,
                SubtractDecimalNullableTotal,
                MultiplyDecimalNullableTotal,
                DivideDecimalNullableTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableTotal(MultiplyDecimalNullableTotal value)
        : this(
            (OneOf<
                AddDecimalNullableTotal,
                SubtractDecimalNullableTotal,
                MultiplyDecimalNullableTotal,
                DivideDecimalNullableTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalNullableTotal(DivideDecimalNullableTotal value)
        : this(
            (OneOf<
                AddDecimalNullableTotal,
                SubtractDecimalNullableTotal,
                MultiplyDecimalNullableTotal,
                DivideDecimalNullableTotal
            >)
                value
        )
    { }

    private ArithmeticDecimalNullableTotal(
        OneOf<
            AddDecimalNullableTotal,
            SubtractDecimalNullableTotal,
            MultiplyDecimalNullableTotal,
            DivideDecimalNullableTotal
        > input
    )
        : base(input) { }
}
