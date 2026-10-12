using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record CoalesceTimeNullableProjection : IOperator
{
    public CoalesceTimeNullableProjection(IEnumerable<TimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableProjection> Values { get; }

    public IType Type => new TypeTimeNullable();
}
