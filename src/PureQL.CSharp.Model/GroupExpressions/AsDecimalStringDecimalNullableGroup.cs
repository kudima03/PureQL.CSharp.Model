using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDecimal.string.decimal.nullable@group</c>.</summary>
public sealed record AsDecimalStringDecimalNullableGroup : IOperator
{
    public AsDecimalStringDecimalNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
