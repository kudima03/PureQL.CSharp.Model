using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalDecimalNullableTotal
    : OneOfBase<IfDecimalNullableTotal, CoalesceDecimalNullableTotal>
{
    public ConditionalDecimalNullableTotal(IfDecimalNullableTotal value)
        : this((OneOf<IfDecimalNullableTotal, CoalesceDecimalNullableTotal>)value) { }

    public ConditionalDecimalNullableTotal(CoalesceDecimalNullableTotal value)
        : this((OneOf<IfDecimalNullableTotal, CoalesceDecimalNullableTotal>)value) { }

    private ConditionalDecimalNullableTotal(
        OneOf<IfDecimalNullableTotal, CoalesceDecimalNullableTotal> input
    )
        : base(input) { }
}
