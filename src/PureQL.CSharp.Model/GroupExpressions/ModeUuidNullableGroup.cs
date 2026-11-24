using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>mode.uuid.nullable@group</c>.</summary>
public sealed record ModeUuidNullableGroup : IOperator
{
    public ModeUuidNullableGroup(
        UuidNullableRow selector,
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

    public UuidNullableRow Selector { get; }

    public IType Type => new TypeUuidNullable();
}
