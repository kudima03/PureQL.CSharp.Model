using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalStringNullableRow
    : OneOfBase<IfStringNullableRow, CoalesceStringNullableRow>
{
    public ConditionalStringNullableRow(IfStringNullableRow value)
        : this((OneOf<IfStringNullableRow, CoalesceStringNullableRow>)value) { }

    public ConditionalStringNullableRow(CoalesceStringNullableRow value)
        : this((OneOf<IfStringNullableRow, CoalesceStringNullableRow>)value) { }

    private ConditionalStringNullableRow(
        OneOf<IfStringNullableRow, CoalesceStringNullableRow> input
    )
        : base(input) { }
}
