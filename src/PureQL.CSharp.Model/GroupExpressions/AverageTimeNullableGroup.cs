using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>average.time.nullable@group</c>.</summary>
public sealed record AverageTimeNullableGroup : IOperator
{
    public AverageTimeNullableGroup(
        TimeNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public TimeNullableRow Selector { get; }

    public IType Type => new TypeTimeNullable();
}
