using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.time.nullable@projection</c>.</summary>
public sealed record GreatestTimeNullableProjection : IOperator
{
    public GreatestTimeNullableProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }

    public IType Type => new TypeTimeNullable();
}
