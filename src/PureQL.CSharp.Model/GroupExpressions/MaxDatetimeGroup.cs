using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.datetime@group</c>.</summary>
public sealed record MaxDatetimeGroup : IOperator
{
    public MaxDatetimeGroup(
        DatetimeRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
