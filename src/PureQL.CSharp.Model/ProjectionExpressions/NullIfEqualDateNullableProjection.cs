using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.date.nullable@projection</c>.</summary>
public sealed record NullIfEqualDateNullableProjection : IOperator
{
    public NullIfEqualDateNullableProjection(
        DateNullableProjection left,
        DateNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public DateNullableProjection Right { get; }

    public IType Type => new TypeDateNullable();
}
