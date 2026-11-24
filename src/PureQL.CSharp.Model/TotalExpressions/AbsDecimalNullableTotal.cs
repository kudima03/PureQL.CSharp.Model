using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>abs.decimal.nullable@total</c>.</summary>
public sealed record AbsDecimalNullableTotal : IOperator
{
    public AbsDecimalNullableTotal(DeclaresDecimalNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalNullableTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
