using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class ConditionalTimeNullableTotal
    : OneOfBase<IfTimeNullableTotal, CoalesceTimeNullableTotal>
{
    public ConditionalTimeNullableTotal(IfTimeNullableTotal value)
        : this((OneOf<IfTimeNullableTotal, CoalesceTimeNullableTotal>)value) { }

    public ConditionalTimeNullableTotal(CoalesceTimeNullableTotal value)
        : this((OneOf<IfTimeNullableTotal, CoalesceTimeNullableTotal>)value) { }

    private ConditionalTimeNullableTotal(
        OneOf<IfTimeNullableTotal, CoalesceTimeNullableTotal> input
    )
        : base(input) { }
}
