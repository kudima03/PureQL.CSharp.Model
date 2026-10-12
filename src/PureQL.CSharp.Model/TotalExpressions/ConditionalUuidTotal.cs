using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalUuidTotal : OneOfBase<IfUuidTotal, CoalesceUuidTotal>
{
    public ConditionalUuidTotal(IfUuidTotal value)
        : this((OneOf<IfUuidTotal, CoalesceUuidTotal>)value) { }

    public ConditionalUuidTotal(CoalesceUuidTotal value)
        : this((OneOf<IfUuidTotal, CoalesceUuidTotal>)value) { }

    private ConditionalUuidTotal(OneOf<IfUuidTotal, CoalesceUuidTotal> input)
        : base(input) { }
}
