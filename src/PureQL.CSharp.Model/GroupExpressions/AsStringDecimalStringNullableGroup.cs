using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.decimal.string.nullable@group</c>.</summary>
public sealed record AsStringDecimalStringNullableGroup : IOperator
{
    public AsStringDecimalStringNullableGroup(
        IntegerNullableOrDecimalNullableGroup operand
    )
    {
        Operand = operand;
    }

    public IntegerNullableOrDecimalNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
