using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal@group</c>.</summary>
public sealed record AsDecimalIntegerDecimalGroup : IOperator
{
    public AsDecimalIntegerDecimalGroup(IntegerGroup operand)
    {
        Operand = operand;
    }

    public IntegerGroup Operand { get; }

    public IType Type => new TypeDecimal();
}
