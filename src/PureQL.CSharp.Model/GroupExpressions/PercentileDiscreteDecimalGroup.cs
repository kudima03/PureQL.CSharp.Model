using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>percentileDiscrete.decimal@group</c>.</summary>
public sealed record PercentileDiscreteDecimalGroup : IOperator
{
    public PercentileDiscreteDecimalGroup(
        DeclaresDecimalRow selector,
        Fraction fraction,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
        Fraction = fraction;
    }

    public AggregateOver Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public Fraction Fraction { get; }

    public IType Type => new TypeDecimal();
}
