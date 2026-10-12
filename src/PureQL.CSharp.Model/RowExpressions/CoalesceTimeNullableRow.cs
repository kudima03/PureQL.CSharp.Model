using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record CoalesceTimeNullableRow : IOperator
{
    public CoalesceTimeNullableRow(IEnumerable<TimeNullableRow> values)
    {
        Values = values;
    }

    public IEnumerable<TimeNullableRow> Values { get; }

    public IType Type => new TypeTimeNullable();
}
