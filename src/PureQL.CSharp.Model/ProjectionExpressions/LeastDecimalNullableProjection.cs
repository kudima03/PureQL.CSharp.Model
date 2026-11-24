using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.decimal.nullable@projection</c>.</summary>
public sealed record LeastDecimalNullableProjection : IOperator
{
    public LeastDecimalNullableProjection(IEnumerable<DecimalNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DecimalNullableProjection> Values { get; }

    public IType Type => new TypeDecimalNullable();
}
