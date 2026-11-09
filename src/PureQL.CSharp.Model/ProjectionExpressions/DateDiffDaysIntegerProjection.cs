using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateDiffDays.integer@projection</c>.</summary>
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
