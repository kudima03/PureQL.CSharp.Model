using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>least.string.nullable@projection</c>.</summary>
public sealed record LeastStringNullableProjection : IOperator
{
    public LeastStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public IType Type => new TypeStringNullable();
}
