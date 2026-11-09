using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>average.date.nullable@group</c>.</summary>
public sealed record AverageDateNullableGroup : IOperator
{
    public AverageDateNullableGroup(
        DateNullableRow selector,
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

    public DateNullableRow Selector { get; }

    public IType Type => new TypeDateNullable();
}
