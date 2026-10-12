using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDatetimeNullableProjection : IOperator
{
    public CoalesceDatetimeNullableProjection(
        IEnumerable<DatetimeNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
