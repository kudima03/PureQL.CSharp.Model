using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal@group</c>.</summary>
public sealed record AsDecimalStringDecimalGroup : IOperator
{
    public AsDecimalStringDecimalGroup(StringGroup operand)
    {
        Operand = operand;
    }

    public StringGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
