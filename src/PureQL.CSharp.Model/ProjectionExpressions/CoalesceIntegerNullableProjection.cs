using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.integer.nullable@projection</c>.</summary>
public sealed record CoalesceIntegerNullableProjection : IOperator
{
    public CoalesceIntegerNullableProjection(
        IEnumerable<DeclaresIntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DeclaresIntegerNullableProjection> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
