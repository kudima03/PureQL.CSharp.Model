using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDatetimeNullableTotal
    : OneOfBase<IfDatetimeNullableTotal, CoalesceDatetimeNullableTotal>
{
    public ConditionalDatetimeNullableTotal(IfDatetimeNullableTotal value)
        : this((OneOf<IfDatetimeNullableTotal, CoalesceDatetimeNullableTotal>)value) { }

    public ConditionalDatetimeNullableTotal(CoalesceDatetimeNullableTotal value)
        : this((OneOf<IfDatetimeNullableTotal, CoalesceDatetimeNullableTotal>)value) { }

    private ConditionalDatetimeNullableTotal(
        OneOf<IfDatetimeNullableTotal, CoalesceDatetimeNullableTotal> input
    )
        : base(input) { }
}
