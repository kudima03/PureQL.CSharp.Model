using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinIntegerGroup : IOperator
{
    public MinIntegerGroup(IntegerRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public IntegerRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeInteger();
}
