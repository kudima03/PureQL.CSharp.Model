using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>acos.decimal@group</c>.</summary>
public sealed record AcosDecimalGroup : IOperator
{
    public AcosDecimalGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
