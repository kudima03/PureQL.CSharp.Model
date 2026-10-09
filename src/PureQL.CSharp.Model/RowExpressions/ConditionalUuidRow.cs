using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalUuidRow : OneOfBase<IfUuidRow, CoalesceUuidRow>
{
    public ConditionalUuidRow(IfUuidRow value)
        : this((OneOf<IfUuidRow, CoalesceUuidRow>)value) { }

    public ConditionalUuidRow(CoalesceUuidRow value)
        : this((OneOf<IfUuidRow, CoalesceUuidRow>)value) { }

    private ConditionalUuidRow(OneOf<IfUuidRow, CoalesceUuidRow> input)
        : base(input) { }
}
