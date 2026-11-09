using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>max.uuid@group</c>.</summary>
public sealed record MaxUuidGroup : IOperator
{
    public MaxUuidGroup(UuidRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public UuidRow Selector { get; }

    public IType Type => new TypeUuid();
}
