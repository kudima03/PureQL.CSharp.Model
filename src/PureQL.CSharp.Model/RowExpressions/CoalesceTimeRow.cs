using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.time@row</c>.</summary>
public sealed record CoalesceTimeRow : IOperator
{
    public CoalesceTimeRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }

    public IType Type => new TypeTime();
}
