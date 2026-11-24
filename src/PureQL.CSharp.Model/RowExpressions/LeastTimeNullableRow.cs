using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.time.nullable@row</c>.</summary>
public sealed record LeastTimeNullableRow : IOperator
{
    public LeastTimeNullableRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }

    public IType Type => new TypeTimeNullable();
}
