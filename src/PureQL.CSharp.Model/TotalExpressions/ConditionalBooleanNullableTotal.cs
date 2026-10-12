using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalBooleanNullableTotal
    : OneOfBase<IfBooleanNullableTotal, CoalesceBooleanNullableTotal>
{
    public ConditionalBooleanNullableTotal(IfBooleanNullableTotal value)
        : this((OneOf<IfBooleanNullableTotal, CoalesceBooleanNullableTotal>)value) { }

    public ConditionalBooleanNullableTotal(CoalesceBooleanNullableTotal value)
        : this((OneOf<IfBooleanNullableTotal, CoalesceBooleanNullableTotal>)value) { }

    private ConditionalBooleanNullableTotal(
        OneOf<IfBooleanNullableTotal, CoalesceBooleanNullableTotal> input
    )
        : base(input) { }
}
