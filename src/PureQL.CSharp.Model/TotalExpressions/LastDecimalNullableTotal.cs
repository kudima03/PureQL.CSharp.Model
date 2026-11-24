using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>last.decimal.nullable@total</c>.</summary>
public sealed record LastDecimalNullableTotal : IOperator
{
    public LastDecimalNullableTotal(
        DecimalOrDecimalNullableRow selector,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Selector = selector;
        OrderBy = orderBy;
    }

    public BooleanRow? Predicate { get; }

    public DecimalOrDecimalNullableRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDecimalNullable();
}
