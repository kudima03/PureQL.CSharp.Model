using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>sign.integer@group</c>.</summary>
public sealed record SignIntegerGroup : IOperator
{
    public SignIntegerGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeInteger();
}
