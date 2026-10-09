using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class AggregateIntegerGroup
    : OneOfBase<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup>
{
    public AggregateIntegerGroup(CountGroup value)
        : this(
            (OneOf<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup>)value
        )
    { }

    public AggregateIntegerGroup(SumIntegerGroup value)
        : this(
            (OneOf<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup>)value
        )
    { }

    public AggregateIntegerGroup(MinIntegerGroup value)
        : this(
            (OneOf<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup>)value
        )
    { }

    public AggregateIntegerGroup(MaxIntegerGroup value)
        : this(
            (OneOf<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup>)value
        )
    { }

    private AggregateIntegerGroup(
        OneOf<CountGroup, SumIntegerGroup, MinIntegerGroup, MaxIntegerGroup> input
    )
        : base(input) { }
}
