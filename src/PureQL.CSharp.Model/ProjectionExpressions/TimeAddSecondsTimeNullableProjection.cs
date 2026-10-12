using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record TimeAddSecondsTimeNullableProjection : IOperator
{
    public TimeAddSecondsTimeNullableProjection(
        TimeNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public TimeNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeTimeNullable();
}
