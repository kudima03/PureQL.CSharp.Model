using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.decimal.nullable@total</c>.</summary>
public sealed record AsNullableDecimalNullableTotal : IOperator
{
    public AsNullableDecimalNullableTotal(DeclaresDecimalTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalTotal Operand { get; }

    public IType Type => new TypeDecimalNullable();
}
