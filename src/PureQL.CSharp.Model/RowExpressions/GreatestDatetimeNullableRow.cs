using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.datetime.nullable@row</c>.</summary>
public sealed record GreatestDatetimeNullableRow : IOperator
{
    public GreatestDatetimeNullableRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
