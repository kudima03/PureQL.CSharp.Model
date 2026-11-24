using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.decimal@group</c>.</summary>
public sealed record TruncateDecimalGroup : IOperator
{
    public TruncateDecimalGroup(DeclaresDecimalGroup operand, IntegerGroup digits)
    {
        Operand = operand;
        Digits = digits;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IntegerGroup Digits { get; }

    public IType Type => new TypeDecimal();
}
