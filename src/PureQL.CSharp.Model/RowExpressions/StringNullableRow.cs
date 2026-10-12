using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class StringNullableRow : OneOfBase<StringRow, ExactStringNullableRow>
{
    public StringNullableRow(StringRow value)
        : this((OneOf<StringRow, ExactStringNullableRow>)value) { }

    public StringNullableRow(ExactStringNullableRow value)
        : this((OneOf<StringRow, ExactStringNullableRow>)value) { }

    private StringNullableRow(OneOf<StringRow, ExactStringNullableRow> input)
        : base(input) { }
}
