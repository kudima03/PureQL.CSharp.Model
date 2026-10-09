using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDecimalGroup
    : OneOfBase<
        CountGroup,
        SumDecimalGroup,
        AverageDecimalGroup,
        MinDecimalGroup,
        MaxDecimalGroup
    >
{
    public AggregateDecimalGroup(CountGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalGroup,
                MinDecimalGroup,
                MaxDecimalGroup
            >)
                value
        )
    { }

    public AggregateDecimalGroup(SumDecimalGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalGroup,
                MinDecimalGroup,
                MaxDecimalGroup
            >)
                value
        )
    { }

    public AggregateDecimalGroup(AverageDecimalGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalGroup,
                MinDecimalGroup,
                MaxDecimalGroup
            >)
                value
        )
    { }

    public AggregateDecimalGroup(MinDecimalGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalGroup,
                MinDecimalGroup,
                MaxDecimalGroup
            >)
                value
        )
    { }

    public AggregateDecimalGroup(MaxDecimalGroup value)
        : this(
            (OneOf<
                CountGroup,
                SumDecimalGroup,
                AverageDecimalGroup,
                MinDecimalGroup,
                MaxDecimalGroup
            >)
                value
        )
    { }

    private AggregateDecimalGroup(
        OneOf<
            CountGroup,
            SumDecimalGroup,
            AverageDecimalGroup,
            MinDecimalGroup,
            MaxDecimalGroup
        > input
    )
        : base(input) { }
}
