using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.withDigits.integer@group</c>.</summary>
public sealed record TruncateWithDigitsIntegerGroup : IOperator
{
    public TruncateWithDigitsIntegerGroup(IntegerGroup operand, IntegerGroup digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public IntegerGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public IType Type => new TypeInteger();
}
