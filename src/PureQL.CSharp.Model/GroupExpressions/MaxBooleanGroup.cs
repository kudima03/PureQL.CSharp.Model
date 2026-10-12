using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxBooleanGroup : IOperator
{
    public MaxBooleanGroup(BooleanRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public BooleanRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeBoolean();
}
