using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalTimeNullableRow
    : OneOfBase<IfTimeNullableRow, CoalesceTimeNullableRow>
{
    public ConditionalTimeNullableRow(IfTimeNullableRow value)
        : this((OneOf<IfTimeNullableRow, CoalesceTimeNullableRow>)value) { }

    public ConditionalTimeNullableRow(CoalesceTimeNullableRow value)
        : this((OneOf<IfTimeNullableRow, CoalesceTimeNullableRow>)value) { }

    private ConditionalTimeNullableRow(
        OneOf<IfTimeNullableRow, CoalesceTimeNullableRow> input
    )
        : base(input) { }
}
