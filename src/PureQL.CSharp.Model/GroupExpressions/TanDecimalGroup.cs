using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tan.decimal@group</c>.</summary>
public sealed record TanDecimalGroup : IOperator
{
    public TanDecimalGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
