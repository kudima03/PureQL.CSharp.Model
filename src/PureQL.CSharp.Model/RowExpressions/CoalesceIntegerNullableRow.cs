using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>coalesce.integer.nullable@row</c>.</summary>
public sealed record CoalesceIntegerNullableRow : IOperator
{
    public CoalesceIntegerNullableRow(IEnumerable<DeclaresIntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<DeclaresIntegerNullableRow> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
