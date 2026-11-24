using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>mode.integer.nullable@group</c>.</summary>
public sealed record ModeIntegerNullableGroup : IOperator
{
    public ModeIntegerNullableGroup(
        IntegerNullableRow selector,
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

    public IntegerNullableRow Selector { get; }

    public IType Type => new TypeIntegerNullable();
}
