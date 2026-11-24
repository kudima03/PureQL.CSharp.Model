using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>standardDeviationPopulation.decimal@group</c>.</summary>
public sealed record StandardDeviationPopulationDecimalGroup : IOperator
{
    public StandardDeviationPopulationDecimalGroup(
        DecimalRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public DecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
