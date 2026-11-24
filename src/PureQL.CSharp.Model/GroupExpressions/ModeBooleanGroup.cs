using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>mode.boolean@group</c>.</summary>
public sealed record ModeBooleanGroup : IOperator
{
    public ModeBooleanGroup(BooleanRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public BooleanRow Selector { get; }

    public IType Type => new TypeBoolean();
}
