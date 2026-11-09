using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>multiply.integer.nullable@row</c>.</summary>
public sealed record MultiplyIntegerNullableRow : IOperator
{
    public MultiplyIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
