using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.datetime@projection</c>.</summary>
public sealed record GreatestDatetimeProjection : IOperator
{
    public GreatestDatetimeProjection(IEnumerable<DatetimeProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeProjection> Values { get; }

    public IType Type => new TypeDatetime();
}
