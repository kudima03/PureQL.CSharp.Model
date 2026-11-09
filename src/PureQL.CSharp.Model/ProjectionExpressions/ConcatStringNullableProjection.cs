using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>concat.string.nullable@projection</c>.</summary>
public sealed record ConcatStringNullableProjection : IOperator
{
    public ConcatStringNullableProjection(IEnumerable<StringNullableProjection> values)
    {
        Values = values;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public IType Type => new TypeStringNullable();
}
