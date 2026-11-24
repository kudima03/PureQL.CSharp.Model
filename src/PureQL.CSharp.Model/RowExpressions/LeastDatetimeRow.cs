using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.datetime@row</c>.</summary>
public sealed record LeastDatetimeRow : IOperator
{
    public LeastDatetimeRow(IEnumerable<DatetimeRow> values)
    {
        Values = values;
    }

    public IEnumerable<DatetimeRow> Values { get; }

    public IType Type => new TypeDatetime();
}
