using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>ceiling.integer@row</c>.</summary>
public sealed record CeilingIntegerRow : IOperator
{
    public CeilingIntegerRow(DeclaresDecimalRow operand)
    {
        Operand = operand;
    }

    public DeclaresDecimalRow Operand { get; }

    public IType Type => new TypeInteger();
}
