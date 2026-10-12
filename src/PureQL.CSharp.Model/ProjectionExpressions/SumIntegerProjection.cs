using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SumIntegerProjection : IOperator
{
    public SumIntegerProjection(IntegerNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public IntegerNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeInteger();
}
