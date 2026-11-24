using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>foldCase.string@total</c>.</summary>
public sealed record FoldCaseStringTotal : IOperator
{
    public FoldCaseStringTotal(StringTotal operand)
    {
        Operand = operand;
    }

    public StringTotal Operand { get; }

    public IType Type => new TypeString();
}
