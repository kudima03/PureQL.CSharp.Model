using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateIntegerNullableGroup
    : OneOfBase<
        CountGroup,
        SumIntegerGroup,
        MinIntegerNullableGroup,
        MaxIntegerNullableGroup
    >
{
    public AggregateIntegerNullableGroup(CountGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumIntegerGroup,
                MinIntegerNullableGroup,
                MaxIntegerNullableGroup
            >)
                value
        )
    { }

    public AggregateIntegerNullableGroup(SumIntegerGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumIntegerGroup,
                MinIntegerNullableGroup,
                MaxIntegerNullableGroup
            >)
                value
        )
    { }

    public AggregateIntegerNullableGroup(MinIntegerNullableGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumIntegerGroup,
                MinIntegerNullableGroup,
                MaxIntegerNullableGroup
            >)
                value
        )
    { }

    public AggregateIntegerNullableGroup(MaxIntegerNullableGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumIntegerGroup,
                MinIntegerNullableGroup,
                MaxIntegerNullableGroup
            >)
                value
        )
    { }

    private AggregateIntegerNullableGroup(
        OneOf<
            CountGroup,
            SumIntegerGroup,
            MinIntegerNullableGroup,
            MaxIntegerNullableGroup
        > input
    )
        : base(input) { }
}
