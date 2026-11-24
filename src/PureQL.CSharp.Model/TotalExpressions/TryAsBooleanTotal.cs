using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsBoolean@total</c>.</summary>
public sealed record TryAsBooleanTotal : IOperator
{
    public TryAsBooleanTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeBooleanNullable();
}
