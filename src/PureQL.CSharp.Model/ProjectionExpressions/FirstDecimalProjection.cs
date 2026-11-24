using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>first.decimal@projection</c>.</summary>
public sealed record FirstDecimalProjection : IOperator
{
    public FirstDecimalProjection(
        DeclaresDecimalRow selector,
        IEnumerable<OrderItemRow> orderBy,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        OrderBy = orderBy;
    }

    public Window? Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public IEnumerable<OrderItemRow> OrderBy { get; }

    public IType Type => new TypeDecimal();
}
