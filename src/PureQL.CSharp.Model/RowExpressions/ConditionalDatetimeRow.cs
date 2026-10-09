using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDatetimeRow : OneOfBase<IfDatetimeRow, CoalesceDatetimeRow>
{
    public ConditionalDatetimeRow(IfDatetimeRow value)
        : this((OneOf<IfDatetimeRow, CoalesceDatetimeRow>)value) { }

    public ConditionalDatetimeRow(CoalesceDatetimeRow value)
        : this((OneOf<IfDatetimeRow, CoalesceDatetimeRow>)value) { }

    private ConditionalDatetimeRow(OneOf<IfDatetimeRow, CoalesceDatetimeRow> input)
        : base(input) { }
}
