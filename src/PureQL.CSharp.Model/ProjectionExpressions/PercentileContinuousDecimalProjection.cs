using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>percentileContinuous.decimal@projection</c>.</summary>
public sealed record PercentileContinuousDecimalProjection : IOperator
{
    public PercentileContinuousDecimalProjection(
        DecimalRow selector,
        Fraction fraction,
        Window? over = null
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public Window? Over { get; }

    public DecimalRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimal();
}
