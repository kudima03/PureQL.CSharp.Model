using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceIntegerNullableRow : IOperator
{
    public CoalesceIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
