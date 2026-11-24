using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.date@row</c>.</summary>
public sealed record LeastDateRow : IOperator
{
    public LeastDateRow(IEnumerable<DateRow> values)
    {
        Values = values;
    }

    public IEnumerable<DateRow> Values { get; }

    public IType Type => new TypeDate();
}
