using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class StringNullableTotal : OneOfBase<StringTotal, ExactStringNullableTotal>
{
    public StringNullableTotal(StringTotal value)
        : this((OneOf<StringTotal, ExactStringNullableTotal>)value) { }

    public StringNullableTotal(ExactStringNullableTotal value)
        : this((OneOf<StringTotal, ExactStringNullableTotal>)value) { }

    private StringNullableTotal(OneOf<StringTotal, ExactStringNullableTotal> input)
        : base(input) { }
}
