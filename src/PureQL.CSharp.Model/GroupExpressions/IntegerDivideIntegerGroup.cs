using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>integerDivide.integer@group</c>.</summary>
public sealed record IntegerDivideIntegerGroup : IOperator
{
    public IntegerDivideIntegerGroup(DecimalGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalGroup Left { get; }

    public DecimalGroup Right { get; }

    public IType Type => new TypeInteger();
}
