using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record AverageDecimalGroup : IOperator
{
    public AverageDecimalGroup(
        DecimalRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Selector = selector;
        Over = over;
    }

    public DecimalRow Selector { get; }

    public AggregateOver Over { get; }

    public IType Type => new TypeDecimal();
}
