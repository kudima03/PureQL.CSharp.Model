using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record SubtractIntegerNullableRow : IOperator
{
    public SubtractIntegerNullableRow(IEnumerable<IntegerNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<IntegerNullableRow> Values { get; }

    public IType Type => new TypeIntegerNullable();
}
