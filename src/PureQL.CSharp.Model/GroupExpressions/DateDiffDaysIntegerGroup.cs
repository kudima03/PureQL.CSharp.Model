using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record DateDiffDaysIntegerGroup : IOperator
{
    public DateDiffDaysIntegerGroup(DateGroup left, DateGroup right)
    {
        Left = left;
        Right = right;
    }

    public DateGroup Left { get; }

    public DateGroup Right { get; }

    public IType Type => new TypeInteger();
}
