using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>nullIfEqual.datetime.nullable@projection</c>.</summary>
public sealed record NullIfEqualDatetimeNullableProjection : IOperator
{
    public NullIfEqualDatetimeNullableProjection(
        DatetimeNullableProjection left,
        DatetimeNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DatetimeNullableProjection Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
