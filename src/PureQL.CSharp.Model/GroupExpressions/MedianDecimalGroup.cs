using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>median.decimal@group</c>.</summary>
public sealed record MedianDecimalGroup : IOperator
{
    public MedianDecimalGroup(
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
