using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalStringNullableTotal
    : OneOfBase<IfStringNullableTotal, CoalesceStringNullableTotal>
{
    public ConditionalStringNullableTotal(IfStringNullableTotal value)
        : this((OneOf<IfStringNullableTotal, CoalesceStringNullableTotal>)value) { }

    public ConditionalStringNullableTotal(CoalesceStringNullableTotal value)
        : this((OneOf<IfStringNullableTotal, CoalesceStringNullableTotal>)value) { }

    private ConditionalStringNullableTotal(
        OneOf<IfStringNullableTotal, CoalesceStringNullableTotal> input
    )
        : base(input) { }
}
