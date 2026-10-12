using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class DecimalRow : OneOfBase<ExactDecimalRow, IntegerRow>
{
    public DecimalRow(ExactDecimalRow value)
        : this((OneOf<ExactDecimalRow, IntegerRow>)value) { }

    public DecimalRow(IntegerRow value)
        : this((OneOf<ExactDecimalRow, IntegerRow>)value) { }

    private DecimalRow(OneOf<ExactDecimalRow, IntegerRow> input)
        : base(input) { }
}
