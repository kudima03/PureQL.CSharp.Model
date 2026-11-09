using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>min.boolean.nullable@group</c>.</summary>
public sealed record MinBooleanNullableGroup : IOperator
{
    public MinBooleanNullableGroup(
        BooleanNullableRow selector,
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

    public BooleanNullableRow Selector { get; }

    public IType Type => new TypeBooleanNullable();
}
