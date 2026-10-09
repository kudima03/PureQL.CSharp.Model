using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDecimalNullableGroup
    : OneOfBase<
        CountGroup,
        SumDecimalGroup,
        AverageDecimalNullableGroup,
        MinDecimalNullableGroup,
        MaxDecimalNullableGroup
    >
{
    public AggregateDecimalNullableGroup(CountGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    public AggregateDecimalNullableGroup(SumDecimalGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    public AggregateDecimalNullableGroup(AverageDecimalNullableGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    public AggregateDecimalNullableGroup(MinDecimalNullableGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    public AggregateDecimalNullableGroup(MaxDecimalNullableGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    private AggregateDecimalNullableGroup(
        OneOf<
            CountGroup,
            SumDecimalGroup,
            AverageDecimalNullableGroup,
            MinDecimalNullableGroup,
            MaxDecimalNullableGroup
        > input
    )
        : base(input) { }
}
