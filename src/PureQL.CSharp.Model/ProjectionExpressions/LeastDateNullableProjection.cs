using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.date.nullable@projection</c>.</summary>
public sealed record LeastDateNullableProjection : IOperator
{
    public LeastDateNullableProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }

    public IType Type => new TypeDateNullable();
}
