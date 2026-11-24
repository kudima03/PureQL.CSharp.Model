using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.decimal.string@group</c>.</summary>
public sealed record AsStringDecimalStringGroup : IOperator
{
    public AsStringDecimalStringGroup(DecimalGroup operand)
    {
        Operand = operand;
    }

    public DecimalGroup Operand { get; }

    public IType Type => new TypeString();
}
