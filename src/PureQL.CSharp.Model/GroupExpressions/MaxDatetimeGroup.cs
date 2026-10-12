using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxDatetimeGroup : IOperator
{
    public MaxDatetimeGroup(
        DatetimeRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Selector = selector;
        Over = over;
    }

    public DatetimeRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeDatetime();
}
