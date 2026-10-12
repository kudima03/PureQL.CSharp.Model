using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDatetimeNullableGroup : IOperator
{
    public AverageDatetimeNullableGroup(
        DatetimeNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Selector = selector;
        Predicate = predicate;
        Over = over;
    }

    public DatetimeNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeDatetimeNullable();
}
