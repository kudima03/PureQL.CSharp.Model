using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateAddDaysDateNullableProjection : IOperator
{
    public DateAddDaysDateNullableProjection(
        DateNullableProjection left,
        IntegerNullableProjection right
    )
    {
        Left = left;
        Right = right;
    }

    public DateNullableProjection Left { get; }

    public IntegerNullableProjection Right { get; }

    public IType Type => new TypeDateNullable();
}
