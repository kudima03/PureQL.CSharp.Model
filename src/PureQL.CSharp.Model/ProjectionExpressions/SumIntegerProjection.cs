using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>sum.integer@projection</c>.</summary>
public sealed record SumIntegerProjection : IOperator
{
    public SumIntegerProjection(IntegerNullableRow selector, BooleanRow? predicate = null)
    {
        Predicate = predicate;
        Selector = selector;
    }

    public BooleanRow? Predicate { get; }

    public IntegerNullableRow Selector { get; }

    public IType Type => new TypeInteger();
}
