using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalIntegerNullableTotal
    : OneOfBase<IfIntegerNullableTotal, CoalesceIntegerNullableTotal>
{
    public ConditionalIntegerNullableTotal(IfIntegerNullableTotal value)
        : this((OneOf<IfIntegerNullableTotal, CoalesceIntegerNullableTotal>)value) { }

    public ConditionalIntegerNullableTotal(CoalesceIntegerNullableTotal value)
        : this((OneOf<IfIntegerNullableTotal, CoalesceIntegerNullableTotal>)value) { }

    private ConditionalIntegerNullableTotal(
        OneOf<IfIntegerNullableTotal, CoalesceIntegerNullableTotal> input
    )
        : base(input) { }
}
