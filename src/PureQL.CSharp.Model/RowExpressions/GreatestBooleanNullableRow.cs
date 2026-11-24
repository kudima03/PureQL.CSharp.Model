using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>greatest.boolean.nullable@row</c>.</summary>
public sealed record GreatestBooleanNullableRow : IOperator
{
    public GreatestBooleanNullableRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
