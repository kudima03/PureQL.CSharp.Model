using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asDecimal.integer.decimal@total</c>.</summary>
public sealed record AsDecimalIntegerDecimalTotal : IOperator
{
    public AsDecimalIntegerDecimalTotal(IntegerTotal operand)
    {
        Operand = operand;
    }

    public IntegerTotal Operand { get; }

    public IType Type => new TypeDecimal();
}
