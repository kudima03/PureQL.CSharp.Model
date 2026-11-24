using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>standardDeviationPopulation.decimal@projection</c>.</summary>
public sealed record StandardDeviationPopulationDecimalProjection : IOperator
{
    public StandardDeviationPopulationDecimalProjection(
        DecimalRow selector,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
    }

    public Window? Over { get; }

    public DecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
