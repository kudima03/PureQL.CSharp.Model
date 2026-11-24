using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.date.nullable@row</c>.</summary>
public sealed record GreatestDateNullableRow : IOperator
{
    public GreatestDateNullableRow(IEnumerable<DateNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateNullableRow> Values { get; }

    public IType Type => new TypeDateNullable();
}
