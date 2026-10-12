using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceDateNullableProjection : IOperator
{
    public CoalesceDateNullableProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }

    public IType Type => new TypeDateNullable();
}
