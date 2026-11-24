using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.date@row</c>.</summary>
public sealed record GreatestDateRow : IOperator
{
    public GreatestDateRow(IEnumerable<DateRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateRow> Values { get; }

    public IType Type => new TypeDate();
}
