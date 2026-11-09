using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>count@group</c>.</summary>
public sealed record CountGroup : IOperator
{
    public CountGroup(
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeInteger();
}
