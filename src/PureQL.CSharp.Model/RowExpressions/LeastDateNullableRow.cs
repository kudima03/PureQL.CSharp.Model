using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.date.nullable@row</c>.</summary>
public sealed record LeastDateNullableRow : IOperator
{
    public LeastDateNullableRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }

    public IType Type => new TypeDateNullable();
}
