using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.datetime@projection</c>.</summary>
public sealed record LeastDatetimeProjection : IOperator
{
    public LeastDatetimeProjection(IEnumerable<DatetimeProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeProjection> Values { get; }

    public IType Type => new TypeDatetime();
}
