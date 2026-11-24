using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>sin.decimal@group</c>.</summary>
public sealed record SinDecimalGroup : IOperator
{
    public SinDecimalGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
