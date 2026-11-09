using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>coalesce.datetime@total</c>.</summary>
public sealed record CoalesceDatetimeTotal : IOperator
{
    public CoalesceDatetimeTotal(IEnumerable<DatetimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableTotal> Values { get; }

    public IType Type => new TypeDatetime();
}
