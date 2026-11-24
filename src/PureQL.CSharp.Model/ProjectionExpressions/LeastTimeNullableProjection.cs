using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.time.nullable@projection</c>.</summary>
public sealed record LeastTimeNullableProjection : IOperator
{
    public LeastTimeNullableProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }

    public IType Type => new TypeTimeNullable();
}
