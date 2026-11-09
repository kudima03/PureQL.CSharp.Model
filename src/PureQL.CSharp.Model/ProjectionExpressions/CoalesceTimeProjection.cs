using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>coalesce.time@projection</c>.</summary>
public sealed record CoalesceTimeProjection : IOperator
{
    public CoalesceTimeProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }

    public IType Type => new TypeTime();
}
