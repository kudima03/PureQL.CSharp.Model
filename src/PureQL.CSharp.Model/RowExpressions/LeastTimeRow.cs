using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.time@row</c>.</summary>
public sealed record LeastTimeRow : IOperator
{
    public LeastTimeRow(IEnumerable<TimeRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeRow> Values { get; }

    public IType Type => new TypeTime();
}
