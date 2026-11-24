using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>correlation@total</c>.</summary>
public sealed record CorrelationTotal : IOperator
{
    public CorrelationTotal(
        DecimalNullableRow left,
        DecimalNullableRow right,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Left = left;
        Right = right;
    }

    public BooleanRow? Predicate { get; }

    public DecimalNullableRow Left { get; }

    public DecimalNullableRow Right { get; }

    public IType Type => new TypeDecimalNullable();
}
