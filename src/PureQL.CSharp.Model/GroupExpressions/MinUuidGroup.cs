using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>min.uuid@group</c>.</summary>
public sealed record MinUuidGroup : IOperator
{
    public MinUuidGroup(UuidRow selector, AggregateOver over = AggregateOver.Group)
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public UuidRow Selector { get; }

    public IType Type => new TypeUuid();
}
