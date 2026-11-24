using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.string@row</c>.</summary>
public sealed record LeastStringRow : IOperator
{
    public LeastStringRow(IEnumerable<StringRow> values)
    {
        Values = values;
    }

    public IEnumerable<StringRow> Values { get; }

    public IType Type => new TypeString();
}
