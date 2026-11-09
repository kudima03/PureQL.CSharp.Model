using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>add.integer@row</c>.</summary>
public sealed record AddIntegerRow : IOperator
{
    public AddIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }

    public IType Type => new TypeInteger();
}
