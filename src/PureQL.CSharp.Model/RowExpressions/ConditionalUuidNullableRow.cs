using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalUuidNullableRow
    : OneOfBase<IfUuidNullableRow, CoalesceUuidNullableRow>
{
    public ConditionalUuidNullableRow(IfUuidNullableRow value)
        : this((OneOf<IfUuidNullableRow, CoalesceUuidNullableRow>)value) { }

    public ConditionalUuidNullableRow(CoalesceUuidNullableRow value)
        : this((OneOf<IfUuidNullableRow, CoalesceUuidNullableRow>)value) { }

    private ConditionalUuidNullableRow(
        OneOf<IfUuidNullableRow, CoalesceUuidNullableRow> input
    )
        : base(input) { }
}
