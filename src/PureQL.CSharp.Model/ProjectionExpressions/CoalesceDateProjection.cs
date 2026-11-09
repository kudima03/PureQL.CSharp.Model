using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.date@projection</c>.</summary>
public sealed record CoalesceDateProjection : IOperator
{
    public CoalesceDateProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }

    public IType Type => new TypeDate();
}
