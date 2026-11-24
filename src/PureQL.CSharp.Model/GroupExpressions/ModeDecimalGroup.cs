using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>mode.decimal@group</c>.</summary>
public sealed record ModeDecimalGroup : IOperator
{
    public ModeDecimalGroup(
        DeclaresDecimalRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public DeclaresDecimalRow Selector { get; }

    public IType Type => new TypeDecimal();
}
