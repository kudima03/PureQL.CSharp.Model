using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.boolean@row</c>.</summary>
public sealed record GreatestBooleanRow : IOperator
{
    public GreatestBooleanRow(IEnumerable<BooleanRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanRow> Values { get; }

    public IType Type => new TypeBoolean();
}
