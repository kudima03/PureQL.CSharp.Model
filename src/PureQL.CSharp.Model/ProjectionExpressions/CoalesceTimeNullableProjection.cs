using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.time.nullable@projection</c>.</summary>
public sealed record CoalesceTimeNullableProjection : IOperator
{
    public CoalesceTimeNullableProjection(
        IEnumerable<DeclaresTimeNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresTimeNullableProjection> Values { get; }

    public IType Type => new TypeTimeNullable();
}
