using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>min.decimal.nullable@group</c>.</summary>
public sealed record MinDecimalNullableGroup : IOperator
{
    public MinDecimalNullableGroup(
        DecimalOrDecimalNullableRow selector,
        BooleanRow? predicate = null,
        AggregateOver over = AggregateOver.Group
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public AggregateOver Over { get; }

    public DecimalOrDecimalNullableRow Selector { get; }

    public IType Type => new TypeDecimalNullable();
}
