using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.boolean.nullable@total</c>.</summary>
public sealed record AsNullableBooleanNullableTotal : IOperator
{
    public AsNullableBooleanNullableTotal(BooleanTotal operand)
    {
        Operand = operand;
    }

    public BooleanTotal Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
