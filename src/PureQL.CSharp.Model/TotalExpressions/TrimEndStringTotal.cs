using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>trimEnd.string@total</c>.</summary>
public sealed record TrimEndStringTotal : IOperator
{
    public TrimEndStringTotal(StringTotal operand, IEnumerable<StringTotal> removables)
    {
        Operand = operand;
        Removables = removables;
    }

    public StringTotal Operand { get; }

    public IEnumerable<StringTotal> Removables { get; }

    public IType Type => new TypeString();
}
