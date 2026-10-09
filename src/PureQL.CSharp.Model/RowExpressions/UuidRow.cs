using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class UuidRow
    : OneOfBase<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow>
{
    public UuidRow(FieldUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow>)value) { }

    public UuidRow(ParamUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow>)value) { }

    public UuidRow(LiteralUuid value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow>)value) { }

    public UuidRow(ConditionalUuidRow value)
        : this((OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow>)value) { }

    private UuidRow(OneOf<FieldUuid, ParamUuid, LiteralUuid, ConditionalUuidRow> input)
        : base(input) { }
}
