using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>least.boolean.nullable@row</c>.</summary>
public sealed record LeastBooleanNullableRow : IOperator
{
    public LeastBooleanNullableRow(IEnumerable<BooleanNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<BooleanNullableRow> Values { get; }

    public IType Type => new TypeBooleanNullable();
}
