using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>concatAll@total</c>.</summary>
public sealed record ConcatAllTotal : IOperator
{
    public ConcatAllTotal(
        StringNullableRow selector,
        Separator separator,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null,
        bool distinct = false
    )
    {
        Predicate = predicate;
        Selector = selector;
        Separator = separator;
        OrderBy = orderBy;
        Distinct = distinct;
    }

    public BooleanRow? Predicate { get; }

    public StringNullableRow Selector { get; }

    public Separator Separator { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public bool Distinct { get; }

    public IType Type => new TypeString();
}
