using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.integer@row</c>.</summary>
public sealed record LeastIntegerRow : IOperator
{
    public LeastIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }

    public IType Type => new TypeInteger();
}
