using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal.nullable@group</c>.</summary>
public sealed record AsDecimalIntegerDecimalNullableGroup : IOperator
{
    public AsDecimalIntegerDecimalNullableGroup(DeclaresIntegerNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresIntegerNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
