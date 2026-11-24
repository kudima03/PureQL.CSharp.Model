using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.time.nullable@row</c>.</summary>
public sealed record GreatestTimeNullableRow : IOperator
{
    public GreatestTimeNullableRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }

    public IType Type => new TypeTimeNullable();
}
