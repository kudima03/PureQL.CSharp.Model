using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>trim.string@total</c>.</summary>
public sealed record TrimStringTotal : IOperator
{
    public TrimStringTotal(StringTotal operand, IEnumerable<StringTotal> removables)
    {
        Operand = operand;
        Removables = removables;
    }

    public StringTotal Operand { get; }

    public IEnumerable<StringTotal> Removables { get; }

    public IType Type => new TypeString();
}
