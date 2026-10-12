using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed record CoalesceDatetimeNullableTotal : IOperator
{
    public CoalesceDatetimeNullableTotal(IEnumerable<DatetimeNullableTotal> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableTotal> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
