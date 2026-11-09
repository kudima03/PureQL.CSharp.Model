using PureQL.CSharp.Model.RowExpressions;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>min.datetime@group</c>.</summary>
public sealed record MinDatetimeGroup : IOperator
{
    public MinDatetimeGroup(
        DatetimeRow selector,
        AggregateOver over = AggregateOver.Group
    )
    {
        Over = over;
        Selector = selector;
    }

    public AggregateOver Over { get; }

    public DatetimeRow Selector { get; }

    public IType Type => new TypeDatetime();
}
