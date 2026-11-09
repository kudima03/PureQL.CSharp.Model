using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.datetime.nullable@projection</c>.</summary>
public sealed record CoalesceDatetimeNullableProjection : IOperator
{
    public CoalesceDatetimeNullableProjection(
        IEnumerable<DeclaresDatetimeNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresDatetimeNullableProjection> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
