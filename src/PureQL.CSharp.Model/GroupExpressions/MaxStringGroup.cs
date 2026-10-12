using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MaxStringGroup : IOperator
{
    public MaxStringGroup(StringRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public StringRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeString();
}
