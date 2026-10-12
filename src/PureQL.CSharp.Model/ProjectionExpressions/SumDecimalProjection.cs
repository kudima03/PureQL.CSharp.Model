using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record SumDecimalProjection : IOperator
{
    public SumDecimalProjection(DecimalNullableRow selector, BooleanRow? predicate = null)
    {
        Selector = selector;
        Predicate = predicate;
    }

    public DecimalNullableRow Selector { get; }

    public BooleanRow? Predicate { get; }

    public IType Type => new TypeDecimal();
}
