using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDecimalNullableGroup
    : OneOfBase<
        AverageDecimalNullableGroup,
        MinDecimalNullableGroup,
        MaxDecimalNullableGroup
    >
{
    public AggregateDecimalNullableGroup(AverageDecimalNullableGroup value)
        : this(
            (OneOf<
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
                AverageDecimalNullableGroup,
                MinDecimalNullableGroup,
                MaxDecimalNullableGroup
            >)
                value
        )
    { }

    private AggregateDecimalNullableGroup(
        OneOf<
            AverageDecimalNullableGroup,
            MinDecimalNullableGroup,
            MaxDecimalNullableGroup
        > input
    )
        : base(input) { }
}
