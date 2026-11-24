using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>abs.decimal@group</c>.</summary>
public sealed record AbsDecimalGroup : IOperator
{
    public AbsDecimalGroup(DeclaresDecimalGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
