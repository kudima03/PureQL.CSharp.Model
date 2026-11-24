using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.date.nullable@projection</c>.</summary>
public sealed record GreatestDateNullableProjection : IOperator
{
    public GreatestDateNullableProjection(IEnumerable<DateNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableProjection> Values { get; }

    public IType Type => new TypeDateNullable();
}
