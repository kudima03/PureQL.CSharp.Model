using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.datetime.nullable@projection</c>.</summary>
public sealed record LeastDatetimeNullableProjection : IOperator
{
    public LeastDatetimeNullableProjection(IEnumerable<DatetimeNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
