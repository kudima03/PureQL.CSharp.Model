using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>correlation@group</c>.</summary>
public sealed record CorrelationGroup : IOperator
{
    public CorrelationGroup(
        DecimalNullableRow left,
        DecimalNullableRow right,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Left = left;
        Right = right;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
