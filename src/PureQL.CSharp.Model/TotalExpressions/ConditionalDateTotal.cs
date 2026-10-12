using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDateTotal : OneOfBase<IfDateTotal, CoalesceDateTotal>
{
    public ConditionalDateTotal(IfDateTotal value)
        : this((OneOf<IfDateTotal, CoalesceDateTotal>)value) { }

    public ConditionalDateTotal(CoalesceDateTotal value)
        : this((OneOf<IfDateTotal, CoalesceDateTotal>)value) { }

    private ConditionalDateTotal(OneOf<IfDateTotal, CoalesceDateTotal> input)
        : base(input) { }
}
