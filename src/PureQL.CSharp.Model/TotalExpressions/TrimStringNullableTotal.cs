using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>trim.string.nullable@total</c>.</summary>
public sealed record TrimStringNullableTotal : IOperator
{
    public TrimStringNullableTotal(
        DeclaresStringNullableTotal operand,
        IEnumerable<StringTotal> removables
    )
    {
        Operand = operand;
        Removables = removables;
    }

    public DeclaresStringNullableTotal Operand { get; }

    public IEnumerable<StringTotal> Removables { get; }

    public IType Type => new TypeStringNullable();
}
