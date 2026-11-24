using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>dateDiffMonths.integer@projection</c>.</summary>
public sealed record DateDiffMonthsIntegerProjection : IOperator
{
    public DateDiffMonthsIntegerProjection(DateProjection left, DateProjection right)
    {
        Left = left;
        Right = right;
    }

    public DateProjection Left { get; }

    public DateProjection Right { get; }

    public IType Type => new TypeInteger();
}
