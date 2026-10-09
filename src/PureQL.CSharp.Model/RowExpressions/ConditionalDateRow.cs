using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDateRow : OneOfBase<IfDateRow, CoalesceDateRow>
{
    public ConditionalDateRow(IfDateRow value)
        : this((OneOf<IfDateRow, CoalesceDateRow>)value) { }

    public ConditionalDateRow(CoalesceDateRow value)
        : this((OneOf<IfDateRow, CoalesceDateRow>)value) { }

    private ConditionalDateRow(OneOf<IfDateRow, CoalesceDateRow> input)
        : base(input) { }
}
