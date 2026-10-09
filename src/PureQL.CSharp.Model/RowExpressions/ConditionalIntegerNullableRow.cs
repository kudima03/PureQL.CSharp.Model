using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalIntegerNullableRow
    : OneOfBase<IfIntegerNullableRow, CoalesceIntegerNullableRow>
{
    public ConditionalIntegerNullableRow(IfIntegerNullableRow value)
        : this((OneOf<IfIntegerNullableRow, CoalesceIntegerNullableRow>)value) { }

    public ConditionalIntegerNullableRow(CoalesceIntegerNullableRow value)
        : this((OneOf<IfIntegerNullableRow, CoalesceIntegerNullableRow>)value) { }

    private ConditionalIntegerNullableRow(
        OneOf<IfIntegerNullableRow, CoalesceIntegerNullableRow> input
    )
        : base(input) { }
}
