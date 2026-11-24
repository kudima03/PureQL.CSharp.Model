using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileContinuous.decimal@group</c>.</summary>
public sealed record PercentileContinuousDecimalGroup : IOperator
{
    public PercentileContinuousDecimalGroup(
        DecimalRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public DecimalRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimal();
}
