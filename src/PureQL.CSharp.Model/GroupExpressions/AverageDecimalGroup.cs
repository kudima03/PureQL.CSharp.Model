using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>average.decimal@group</c>.</summary>
public sealed record AverageDecimalGroup : IOperator
{
    public AverageDecimalGroup(
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
