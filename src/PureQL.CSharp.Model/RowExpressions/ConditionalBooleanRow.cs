using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalBooleanRow : OneOfBase<IfBooleanRow, CoalesceBooleanRow>
{
    public ConditionalBooleanRow(IfBooleanRow value)
        : this((OneOf<IfBooleanRow, CoalesceBooleanRow>)value) { }

    public ConditionalBooleanRow(CoalesceBooleanRow value)
        : this((OneOf<IfBooleanRow, CoalesceBooleanRow>)value) { }

    private ConditionalBooleanRow(OneOf<IfBooleanRow, CoalesceBooleanRow> input)
        : base(input) { }
}
