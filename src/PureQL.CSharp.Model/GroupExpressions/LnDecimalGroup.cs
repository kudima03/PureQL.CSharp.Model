using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>ln.decimal@group</c>.</summary>
public sealed record LnDecimalGroup : IOperator
{
    public LnDecimalGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
