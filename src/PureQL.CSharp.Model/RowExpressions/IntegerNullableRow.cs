using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class IntegerNullableRow : OneOfBase<IntegerRow, ExactIntegerNullableRow>
{
    public IntegerNullableRow(IntegerRow value)
        : this((OneOf<IntegerRow, ExactIntegerNullableRow>)value) { }

    public IntegerNullableRow(ExactIntegerNullableRow value)
        : this((OneOf<IntegerRow, ExactIntegerNullableRow>)value) { }

    private IntegerNullableRow(OneOf<IntegerRow, ExactIntegerNullableRow> input)
        : base(input) { }
}
