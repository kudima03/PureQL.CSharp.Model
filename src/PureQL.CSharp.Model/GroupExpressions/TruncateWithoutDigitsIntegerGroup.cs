using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer@group</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerGroup : IOperator
{
    public TruncateWithoutDigitsIntegerGroup(DeclaresDecimalGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IType Type => new TypeInteger();
}
