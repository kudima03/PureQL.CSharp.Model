using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>position.integer.nullable@total</c>.</summary>
public sealed record PositionIntegerNullableTotal : IOperator
{
    public PositionIntegerNullableTotal(
        StringNullableTotal operand,
        StringNullableTotal pattern,
        IntegerNullableTotal? start = null
    )
    {
        Operand = operand;
        Pattern = pattern;
        Start = start;
    }

    public StringNullableTotal Operand { get; }

    public StringNullableTotal Pattern { get; }

    public IntegerNullableTotal? Start { get; }

    public IType Type => new TypeIntegerNullable();
}
