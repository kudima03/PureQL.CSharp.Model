using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalBooleanTotal
    : OneOfBase<IfBooleanTotal, CoalesceBooleanTotal>
{
    public ConditionalBooleanTotal(IfBooleanTotal value)
        : this((OneOf<IfBooleanTotal, CoalesceBooleanTotal>)value) { }

    public ConditionalBooleanTotal(CoalesceBooleanTotal value)
        : this((OneOf<IfBooleanTotal, CoalesceBooleanTotal>)value) { }

    private ConditionalBooleanTotal(OneOf<IfBooleanTotal, CoalesceBooleanTotal> input)
        : base(input) { }
}
