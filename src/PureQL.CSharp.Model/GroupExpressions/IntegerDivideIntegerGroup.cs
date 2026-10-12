using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record IntegerDivideIntegerGroup : IOperator
{
    public IntegerDivideIntegerGroup(IntegerGroup left, IntegerGroup right)
    {
        Left = left;
        Right = right;
    }

    public IntegerGroup Left { get; }

    public IntegerGroup Right { get; }

    public IType Type => new TypeInteger();
}
