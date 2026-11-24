using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.integer@row</c>.</summary>
public sealed record GreatestIntegerRow : IOperator
{
    public GreatestIntegerRow(IEnumerable<IntegerRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerRow> Values { get; }

    public IType Type => new TypeInteger();
}
