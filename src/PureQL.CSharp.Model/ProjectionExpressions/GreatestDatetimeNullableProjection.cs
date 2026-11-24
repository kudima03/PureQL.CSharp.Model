using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.datetime.nullable@projection</c>.</summary>
public sealed record GreatestDatetimeNullableProjection : IOperator
{
    public GreatestDatetimeNullableProjection(
        IEnumerable<DatetimeNullableProjection> values
    )
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableProjection> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
