using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsDecimal@total</c>.</summary>
public sealed record TryAsDecimalTotal : IOperator
{
    public TryAsDecimalTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
