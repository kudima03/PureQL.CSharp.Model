using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record DateAddDaysDateProjection : IOperator
{
    public DateAddDaysDateProjection(DateProjection left, IntegerProjection right)
    {
        Left = left;
        Right = right;
    }

    public DateProjection Left { get; }

    public IntegerProjection Right { get; }

    public IType Type => new TypeDate();
}
