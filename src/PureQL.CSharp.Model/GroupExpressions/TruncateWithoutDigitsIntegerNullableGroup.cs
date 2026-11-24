using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>truncate.withoutDigits.integer.nullable@group</c>.</summary>
public sealed record TruncateWithoutDigitsIntegerNullableGroup : IOperator
{
    public TruncateWithoutDigitsIntegerNullableGroup(DeclaresDecimalNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
