using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>regressionSlope@total</c>.</summary>
public sealed record RegressionSlopeTotal : IOperator
{
    public RegressionSlopeTotal(
        DecimalNullableRow y,
        DecimalNullableRow x,
        BooleanRow? predicate = null
    )
    {
        Predicate = predicate;
        Y = y;
        X = x;
    }

    public BooleanRow? Predicate { get; }

    public DecimalNullableRow Y { get; }

    public DecimalNullableRow X { get; }

    public IType Type => new TypeDecimalNullable();
}
