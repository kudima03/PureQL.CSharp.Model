using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>concatAll@projection</c>.</summary>
public sealed record ConcatAllProjection : IOperator
{
    public ConcatAllProjection(
        StringNullableRow selector,
        Separator separator,
        IEnumerable<OrderItemRow> orderBy,
        BooleanRow? predicate = null,
        Window? over = null,
        bool distinct = false
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
        Separator = separator;
        OrderBy = orderBy;
        Distinct = distinct;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public StringNullableRow Selector { get; }

    public Separator Separator { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public bool Distinct { get; }

    public IType Type => new TypeString();
}
