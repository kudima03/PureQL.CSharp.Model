using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>trimEnd.string.nullable@total</c>.</summary>
public sealed record TrimEndStringNullableTotal : IOperator
{
    public TrimEndStringNullableTotal(
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
