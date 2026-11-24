using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>countDistinct@projection</c>.</summary>
public sealed record CountDistinctProjection : IOperator
{
    public CountDistinctProjection(
        ExprRow selector,
        BooleanRow? predicate = null,
        Window? over = null
    )
    {
        Predicate = predicate;
        Over = over;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public ExprRow Selector { get; }

    public IType Type => new TypeInteger();
}
