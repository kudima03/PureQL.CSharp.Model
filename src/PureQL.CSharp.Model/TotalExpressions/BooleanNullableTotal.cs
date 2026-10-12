using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class BooleanNullableTotal
    : OneOfBase<BooleanTotal, ExactBooleanNullableTotal>
{
    public BooleanNullableTotal(BooleanTotal value)
        : this((OneOf<BooleanTotal, ExactBooleanNullableTotal>)value) { }

    public BooleanNullableTotal(ExactBooleanNullableTotal value)
        : this((OneOf<BooleanTotal, ExactBooleanNullableTotal>)value) { }

    private BooleanNullableTotal(OneOf<BooleanTotal, ExactBooleanNullableTotal> input)
        : base(input) { }
}
