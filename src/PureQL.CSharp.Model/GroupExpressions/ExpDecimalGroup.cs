using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>exp.decimal@group</c>.</summary>
public sealed record ExpDecimalGroup : IOperator
{
    public ExpDecimalGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
