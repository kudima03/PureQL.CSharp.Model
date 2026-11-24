using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.string@row</c>.</summary>
public sealed record GreatestStringRow : IOperator
{
    public GreatestStringRow(IEnumerable<StringRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringRow> Values { get; }

    public IType Type => new TypeString();
}
