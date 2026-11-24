using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.datetime@row</c>.</summary>
public sealed record GreatestDatetimeRow : IOperator
{
    public GreatestDatetimeRow(IEnumerable<DatetimeRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeRow> Values { get; }

    public IType Type => new TypeDatetime();
}
