using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.time@row</c>.</summary>
public sealed record GreatestTimeRow : IOperator
{
    public GreatestTimeRow(IEnumerable<TimeRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeRow> Values { get; }

    public IType Type => new TypeTime();
}
