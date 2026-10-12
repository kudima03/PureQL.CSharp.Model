using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDatetimeProjection : IOperator
{
    public CoalesceDatetimeProjection(IEnumerable<DatetimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }

    public IType Type => new TypeDatetime();
}
