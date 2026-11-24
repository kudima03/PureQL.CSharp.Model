using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.string.nullable@projection</c>.</summary>
public sealed record NullIfEqualStringNullableProjection : IOperator
{
    public NullIfEqualStringNullableProjection(
        StringNullableProjection left,
        StringNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public StringNullableProjection Left { get; }

    public StringNullableProjection Right { get; }

    public IType Type => new TypeStringNullable();
}
