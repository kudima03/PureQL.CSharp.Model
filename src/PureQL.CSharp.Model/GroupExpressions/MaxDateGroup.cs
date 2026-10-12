using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxDateGroup : IOperator
{
    public MaxDateGroup(DateRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public DateRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeDate();
}
