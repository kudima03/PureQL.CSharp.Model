using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateDecimalGroup
    : OneOfBase<SumDecimalGroup, AverageDecimalGroup, MinDecimalGroup, MaxDecimalGroup>
{
    public AggregateDecimalGroup(SumDecimalGroup value)
        : this(
            (OneOf<
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
            SumDecimalGroup,
            AverageDecimalGroup,
            MinDecimalGroup,
            MaxDecimalGroup
        > input
    )
        : base(input) { }
}
