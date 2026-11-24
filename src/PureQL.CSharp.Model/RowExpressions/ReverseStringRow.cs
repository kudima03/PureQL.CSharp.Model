using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>reverse.string@row</c>.</summary>
public sealed record ReverseStringRow : IOperator
{
    public ReverseStringRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeString();
}
