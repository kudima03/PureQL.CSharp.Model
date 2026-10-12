using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateDiffDaysIntegerProjection : IOperator
{
    public DateDiffDaysIntegerProjection(DateProjection left, DateProjection right)
    {
        Left = left;
        Right = right;
    }

    public DateProjection Left { get; }

    public DateProjection Right { get; }

    public IType Type => new TypeInteger();
}
