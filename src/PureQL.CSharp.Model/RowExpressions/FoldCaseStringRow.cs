using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>foldCase.string@row</c>.</summary>
public sealed record FoldCaseStringRow : IOperator
{
    public FoldCaseStringRow(StringRow operand)
    {
        Operand = operand;
    }

    public StringRow Operand { get; }

    public IType Type => new TypeString();
}
