using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>sum.integer@total</c>.</summary>
public sealed record SumIntegerTotal : IOperator
{
    public SumIntegerTotal(IntegerNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public IntegerNullableRow Selector { get; }

    public IType Type => new TypeInteger();
}
