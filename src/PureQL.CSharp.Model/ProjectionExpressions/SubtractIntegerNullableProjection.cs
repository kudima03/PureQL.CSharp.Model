using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>subtract.integer.nullable@projection</c>.</summary>
public sealed record SubtractIntegerNullableProjection : IOperator
{
    public SubtractIntegerNullableProjection(
        IEnumerable<IntegerNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableProjection> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
