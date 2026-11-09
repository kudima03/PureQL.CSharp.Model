using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.integer@row</c>.</summary>
public sealed record CoalesceIntegerRow : IOperator
{
    public CoalesceIntegerRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }

    public IType Type => new TypeInteger();
}
