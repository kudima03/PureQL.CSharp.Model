using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class AggregateDecimalNullableTotal
    : OneOfBase<
        AverageDecimalNullableTotal,
        MinDecimalNullableTotal,
        MaxDecimalNullableTotal
    >
{
    public AggregateDecimalNullableTotal(AverageDecimalNullableTotal value)
        : this(
            (OneOf<
                AverageDecimalNullableTotal,
                MinDecimalNullableTotal,
                MaxDecimalNullableTotal
            >)
                value
        )
    { }

    public AggregateDecimalNullableTotal(MinDecimalNullableTotal value)
        : this(
            (OneOf<
                AverageDecimalNullableTotal,
                MinDecimalNullableTotal,
                MaxDecimalNullableTotal
            >)
                value
        )
    { }

    public AggregateDecimalNullableTotal(MaxDecimalNullableTotal value)
        : this(
            (OneOf<
                AverageDecimalNullableTotal,
                MinDecimalNullableTotal,
                MaxDecimalNullableTotal
            >)
                value
        )
    { }

    private AggregateDecimalNullableTotal(
        OneOf<
            AverageDecimalNullableTotal,
            MinDecimalNullableTotal,
            MaxDecimalNullableTotal
        > input
    )
        : base(input) { }
}
