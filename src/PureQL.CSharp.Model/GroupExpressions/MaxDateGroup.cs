using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.date@group</c>.</summary>
public sealed record MaxDateGroup : IOperator
{
    public MaxDateGroup(DateRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public DateRow Selector { get; }

    public IType Type => new TypeDate();
}
