using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asBoolean.boolean.nullable@total</c>.</summary>
public sealed record AsBooleanBooleanNullableTotal : IOperator
{
    public AsBooleanBooleanNullableTotal(DeclaresStringNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
