using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>trimEnd.string@row</c>.</summary>
public sealed record TrimEndStringRow : IOperator
{
    public TrimEndStringRow(StringRow operand, IEnumerable<StringRow> removables)
    {
        Operand = operand;
        Removables = removables;
    }

    public StringRow Operand { get; }

    public IEnumerable<StringRow> Removables { get; }

    public IType Type => new TypeString();
}
