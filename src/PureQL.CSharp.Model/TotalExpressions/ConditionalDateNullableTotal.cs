using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDateNullableTotal
    : OneOfBase<IfDateNullableTotal, CoalesceDateNullableTotal>
{
    public ConditionalDateNullableTotal(IfDateNullableTotal value)
        : this((OneOf<IfDateNullableTotal, CoalesceDateNullableTotal>)value) { }

    public ConditionalDateNullableTotal(CoalesceDateNullableTotal value)
        : this((OneOf<IfDateNullableTotal, CoalesceDateNullableTotal>)value) { }

    private ConditionalDateNullableTotal(
        OneOf<IfDateNullableTotal, CoalesceDateNullableTotal> input
    )
        : base(input) { }
}
