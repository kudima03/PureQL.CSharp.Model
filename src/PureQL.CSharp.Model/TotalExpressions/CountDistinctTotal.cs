using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>countDistinct@total</c>.</summary>
public sealed record CountDistinctTotal : IOperator
{
    public CountDistinctTotal(ExprRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public ExprRow Selector { get; }

    public IType Type => new TypeInteger();
}
