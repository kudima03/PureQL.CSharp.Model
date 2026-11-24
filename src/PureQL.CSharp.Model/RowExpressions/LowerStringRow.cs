using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>lower.string@row</c>.</summary>
public sealed record LowerStringRow : IOperator
{
    public LowerStringRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeString();
}
