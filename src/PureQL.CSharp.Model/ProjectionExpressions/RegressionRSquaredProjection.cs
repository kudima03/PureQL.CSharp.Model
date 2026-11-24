using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>regressionRSquared@projection</c>.</summary>
public sealed record RegressionRSquaredProjection : IOperator
{
    public RegressionRSquaredProjection(
        DecimalNullableRow y,
        DecimalNullableRow x,
        BooleanRow? predicate = null,
        Window? over = null
    )
    {
        Predicate = predicate;
        Over = over;
        Y = y;
        X = x;
    }

    public BooleanRow? Predicate { get; }

    public Window? Over { get; }

    public DecimalNullableRow Y { get; }

    public DecimalNullableRow X { get; }

    public IType Type => new TypeDecimalNullable();
}
