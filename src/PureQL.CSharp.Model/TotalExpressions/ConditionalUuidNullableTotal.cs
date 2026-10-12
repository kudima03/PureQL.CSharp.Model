using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalUuidNullableTotal
    : OneOfBase<IfUuidNullableTotal, CoalesceUuidNullableTotal>
{
    public ConditionalUuidNullableTotal(IfUuidNullableTotal value)
        : this((OneOf<IfUuidNullableTotal, CoalesceUuidNullableTotal>)value) { }

    public ConditionalUuidNullableTotal(CoalesceUuidNullableTotal value)
        : this((OneOf<IfUuidNullableTotal, CoalesceUuidNullableTotal>)value) { }

    private ConditionalUuidNullableTotal(
        OneOf<IfUuidNullableTotal, CoalesceUuidNullableTotal> input
    )
        : base(input) { }
}
