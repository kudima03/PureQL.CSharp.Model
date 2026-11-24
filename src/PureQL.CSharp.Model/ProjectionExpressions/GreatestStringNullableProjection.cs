using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>greatest.string.nullable@projection</c>.</summary>
public sealed record GreatestStringNullableProjection : IOperator
{
    public GreatestStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public IType Type => new TypeStringNullable();
}
