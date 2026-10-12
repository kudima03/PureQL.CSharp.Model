using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ArithmeticDecimalTotal
    : OneOfBase<
        AddDecimalTotal,
        SubtractDecimalTotal,
        MultiplyDecimalTotal,
        DivideDecimalTotal
    >
{
    public ArithmeticDecimalTotal(AddDecimalTotal value)
        : this(
            (OneOf<
                AddDecimalTotal,
                SubtractDecimalTotal,
                MultiplyDecimalTotal,
                DivideDecimalTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalTotal(SubtractDecimalTotal value)
        : this(
            (OneOf<
                AddDecimalTotal,
                SubtractDecimalTotal,
                MultiplyDecimalTotal,
                DivideDecimalTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalTotal(MultiplyDecimalTotal value)
        : this(
            (OneOf<
                AddDecimalTotal,
                SubtractDecimalTotal,
                MultiplyDecimalTotal,
                DivideDecimalTotal
            >)
                value
        )
    { }

    public ArithmeticDecimalTotal(DivideDecimalTotal value)
        : this(
            (OneOf<
                AddDecimalTotal,
                SubtractDecimalTotal,
                MultiplyDecimalTotal,
                DivideDecimalTotal
            >)
                value
        )
    { }

    private ArithmeticDecimalTotal(
        OneOf<
            AddDecimalTotal,
            SubtractDecimalTotal,
            MultiplyDecimalTotal,
            DivideDecimalTotal
        > input
    )
        : base(input) { }
}
