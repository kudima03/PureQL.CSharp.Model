using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>covariancePopulation.decimal@projection</c>.</summary>
public sealed record CovariancePopulationDecimalProjection : IOperator
{
    public CovariancePopulationDecimalProjection(
        DecimalRow left,
        DecimalRow right,
        Window? over = null
    )
    {
        Over = over;
        Left = left;
        Right = right;
    }

    public Window? Over { get; }

    public DecimalRow Left { get; }

    public DecimalRow Right { get; }

    public IType Type => new TypeDecimal();
}
