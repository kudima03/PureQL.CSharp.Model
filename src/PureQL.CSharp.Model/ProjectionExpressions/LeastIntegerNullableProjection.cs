using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.integer.nullable@projection</c>.</summary>
public sealed record LeastIntegerNullableProjection : IOperator
{
    public LeastIntegerNullableProjection(IEnumerable<IntegerNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
