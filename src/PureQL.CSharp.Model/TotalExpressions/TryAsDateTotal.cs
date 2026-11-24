using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsDate@total</c>.</summary>
public sealed record TryAsDateTotal : IOperator
{
    public TryAsDateTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeDateNullable();
}
