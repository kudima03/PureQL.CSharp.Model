using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsUuid@total</c>.</summary>
public sealed record TryAsUuidTotal : IOperator
{
    public TryAsUuidTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeUuidNullable();
}
