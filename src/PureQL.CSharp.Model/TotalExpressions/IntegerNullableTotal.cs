using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class IntegerNullableTotal
    : OneOfBase<IntegerTotal, ExactIntegerNullableTotal>
{
    public IntegerNullableTotal(IntegerTotal value)
        : this((OneOf<IntegerTotal, ExactIntegerNullableTotal>)value) { }

    public IntegerNullableTotal(ExactIntegerNullableTotal value)
        : this((OneOf<IntegerTotal, ExactIntegerNullableTotal>)value) { }

    private IntegerNullableTotal(OneOf<IntegerTotal, ExactIntegerNullableTotal> input)
        : base(input) { }
}
