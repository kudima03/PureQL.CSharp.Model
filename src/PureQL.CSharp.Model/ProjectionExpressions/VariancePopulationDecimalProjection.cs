using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>variancePopulation.decimal@projection</c>.</summary>
public sealed record VariancePopulationDecimalProjection : IOperator
{
    public VariancePopulationDecimalProjection(DecimalRow selector, Window? over = null)
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
