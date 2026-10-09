using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalDecimalNullableRow
    : OneOfBase<IfDecimalNullableRow, CoalesceDecimalNullableRow>
{
    public ConditionalDecimalNullableRow(IfDecimalNullableRow value)
        : this((OneOf<IfDecimalNullableRow, CoalesceDecimalNullableRow>)value) { }

    public ConditionalDecimalNullableRow(CoalesceDecimalNullableRow value)
        : this((OneOf<IfDecimalNullableRow, CoalesceDecimalNullableRow>)value) { }

    private ConditionalDecimalNullableRow(
        OneOf<IfDecimalNullableRow, CoalesceDecimalNullableRow> input
    )
        : base(input) { }
}
