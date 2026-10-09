using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDatetimeNullableRow
    : OneOfBase<IfDatetimeNullableRow, CoalesceDatetimeNullableRow>
{
    public ConditionalDatetimeNullableRow(IfDatetimeNullableRow value)
        : this((OneOf<IfDatetimeNullableRow, CoalesceDatetimeNullableRow>)value) { }

    public ConditionalDatetimeNullableRow(CoalesceDatetimeNullableRow value)
        : this((OneOf<IfDatetimeNullableRow, CoalesceDatetimeNullableRow>)value) { }

    private ConditionalDatetimeNullableRow(
        OneOf<IfDatetimeNullableRow, CoalesceDatetimeNullableRow> input
    )
        : base(input) { }
}
