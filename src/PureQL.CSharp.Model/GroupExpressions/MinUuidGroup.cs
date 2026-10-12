using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record MinUuidGroup : IOperator
{
    public MinUuidGroup(UuidRow selector, AggregateOver over = AggregateOver.Group)
    {
        Selector = selector;
        Over = over;
    }

    public UuidRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeUuid();
}
