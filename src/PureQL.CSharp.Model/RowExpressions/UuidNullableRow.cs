using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class UuidNullableRow : OneOfBase<UuidRow, ExactUuidNullableRow>
{
    public UuidNullableRow(UuidRow value)
        : this((OneOf<UuidRow, ExactUuidNullableRow>)value) { }

    public UuidNullableRow(ExactUuidNullableRow value)
        : this((OneOf<UuidRow, ExactUuidNullableRow>)value) { }

    private UuidNullableRow(OneOf<UuidRow, ExactUuidNullableRow> input)
        : base(input) { }
}
