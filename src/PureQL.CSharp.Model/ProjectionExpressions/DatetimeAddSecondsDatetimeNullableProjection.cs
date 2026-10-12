using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DatetimeAddSecondsDatetimeNullableProjection : IOperator
{
    public DatetimeAddSecondsDatetimeNullableProjection(
        DatetimeNullableProjection left,
        DecimalNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DatetimeNullableProjection Left { get; }

    public DecimalNullableProjection Right { get; }

    public IType Type => new TypeDatetimeNullable();
}
