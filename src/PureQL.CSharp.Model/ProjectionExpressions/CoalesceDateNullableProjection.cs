using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.date.nullable@projection</c>.</summary>
public sealed record CoalesceDateNullableProjection : IOperator
{
    public CoalesceDateNullableProjection(
        IEnumerable<DeclaresDateNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresDateNullableProjection> Values { get; }

    public IType Type => new TypeDateNullable();
}
