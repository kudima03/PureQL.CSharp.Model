using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>tryAsDatetime@total</c>.</summary>
public sealed record TryAsDatetimeTotal : IOperator
{
    public TryAsDatetimeTotal(StringNullableTotal operand)
    {
        Operand = operand;
    }

    public StringNullableTotal Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
