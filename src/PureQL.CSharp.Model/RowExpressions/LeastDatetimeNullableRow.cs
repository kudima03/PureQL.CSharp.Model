using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.datetime.nullable@row</c>.</summary>
public sealed record LeastDatetimeNullableRow : IOperator
{
    public LeastDatetimeNullableRow(IEnumerable<DatetimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeNullableRow> Values { get; }

    public IType Type => new TypeDatetimeNullable();
}
