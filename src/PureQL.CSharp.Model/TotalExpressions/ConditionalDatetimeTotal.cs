using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDatetimeTotal
    : OneOfBase<IfDatetimeTotal, CoalesceDatetimeTotal>
{
    public ConditionalDatetimeTotal(IfDatetimeTotal value)
        : this((OneOf<IfDatetimeTotal, CoalesceDatetimeTotal>)value) { }

    public ConditionalDatetimeTotal(CoalesceDatetimeTotal value)
        : this((OneOf<IfDatetimeTotal, CoalesceDatetimeTotal>)value) { }

    private ConditionalDatetimeTotal(OneOf<IfDatetimeTotal, CoalesceDatetimeTotal> input)
        : base(input) { }
}
