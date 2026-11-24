using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsTime@total</c>.</summary>
public sealed record TryAsTimeTotal : IOperator
{
    public TryAsTimeTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
