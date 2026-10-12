using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class BooleanNullableRow : OneOfBase<BooleanRow, ExactBooleanNullableRow>
{
    public BooleanNullableRow(BooleanRow value)
        : this((OneOf<BooleanRow, ExactBooleanNullableRow>)value) { }

    public BooleanNullableRow(ExactBooleanNullableRow value)
        : this((OneOf<BooleanRow, ExactBooleanNullableRow>)value) { }

    private BooleanNullableRow(OneOf<BooleanRow, ExactBooleanNullableRow> input)
        : base(input) { }
}
