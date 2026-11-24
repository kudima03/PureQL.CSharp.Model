using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsInteger@total</c>.</summary>
public sealed record TryAsIntegerTotal : IOperator
{
    public TryAsIntegerTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
