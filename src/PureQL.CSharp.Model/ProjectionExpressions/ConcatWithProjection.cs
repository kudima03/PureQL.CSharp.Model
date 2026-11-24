using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>concatWith@projection</c>.</summary>
public sealed record ConcatWithProjection : IOperator
{
    public ConcatWithProjection(
        IEnumerable<StringNullableProjection> values,
        StringProjection separator
    )
    {
        Values = values;
        Separator = separator;
    }

    public IEnumerable<StringNullableProjection> Values { get; }

    public StringProjection Separator { get; }

    public IType Type => new TypeString();
}
