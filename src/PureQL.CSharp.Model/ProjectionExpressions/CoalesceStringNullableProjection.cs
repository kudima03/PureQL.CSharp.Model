using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.string.nullable@projection</c>.</summary>
public sealed record CoalesceStringNullableProjection : IOperator
{
    public CoalesceStringNullableProjection(
        IEnumerable<DeclaresStringNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresStringNullableProjection> Values { get; }

    public IType Type => new TypeStringNullable();
}
