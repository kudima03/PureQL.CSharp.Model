using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalIntegerRow : OneOfBase<IfIntegerRow, CoalesceIntegerRow>
{
    public ConditionalIntegerRow(IfIntegerRow value)
        : this((OneOf<IfIntegerRow, CoalesceIntegerRow>)value) { }

    public ConditionalIntegerRow(CoalesceIntegerRow value)
        : this((OneOf<IfIntegerRow, CoalesceIntegerRow>)value) { }

    private ConditionalIntegerRow(OneOf<IfIntegerRow, CoalesceIntegerRow> input)
        : base(input) { }
}
