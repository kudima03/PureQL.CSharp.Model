using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDateNullableRow
    : OneOfBase<IfDateNullableRow, CoalesceDateNullableRow>
{
    public ConditionalDateNullableRow(IfDateNullableRow value)
        : this((OneOf<IfDateNullableRow, CoalesceDateNullableRow>)value) { }

    public ConditionalDateNullableRow(CoalesceDateNullableRow value)
        : this((OneOf<IfDateNullableRow, CoalesceDateNullableRow>)value) { }

    private ConditionalDateNullableRow(
        OneOf<IfDateNullableRow, CoalesceDateNullableRow> input
    )
        : base(input) { }
}
