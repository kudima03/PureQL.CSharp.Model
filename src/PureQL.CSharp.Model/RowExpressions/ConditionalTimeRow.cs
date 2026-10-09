using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalTimeRow : OneOfBase<IfTimeRow, CoalesceTimeRow>
{
    public ConditionalTimeRow(IfTimeRow value)
        : this((OneOf<IfTimeRow, CoalesceTimeRow>)value) { }

    public ConditionalTimeRow(CoalesceTimeRow value)
        : this((OneOf<IfTimeRow, CoalesceTimeRow>)value) { }

    private ConditionalTimeRow(OneOf<IfTimeRow, CoalesceTimeRow> input)
        : base(input) { }
}
