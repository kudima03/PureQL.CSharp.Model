using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDecimalRow : OneOfBase<IfDecimalRow, CoalesceDecimalRow>
{
    public ConditionalDecimalRow(IfDecimalRow value)
        : this((OneOf<IfDecimalRow, CoalesceDecimalRow>)value) { }

    public ConditionalDecimalRow(CoalesceDecimalRow value)
        : this((OneOf<IfDecimalRow, CoalesceDecimalRow>)value) { }

    private ConditionalDecimalRow(OneOf<IfDecimalRow, CoalesceDecimalRow> input)
        : base(input) { }
}
