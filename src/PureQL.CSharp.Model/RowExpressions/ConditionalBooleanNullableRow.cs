using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalBooleanNullableRow
    : OneOfBase<IfBooleanNullableRow, CoalesceBooleanNullableRow>
{
    public ConditionalBooleanNullableRow(IfBooleanNullableRow value)
        : this((OneOf<IfBooleanNullableRow, CoalesceBooleanNullableRow>)value) { }

    public ConditionalBooleanNullableRow(CoalesceBooleanNullableRow value)
        : this((OneOf<IfBooleanNullableRow, CoalesceBooleanNullableRow>)value) { }

    private ConditionalBooleanNullableRow(
        OneOf<IfBooleanNullableRow, CoalesceBooleanNullableRow> input
    )
        : base(input) { }
}
