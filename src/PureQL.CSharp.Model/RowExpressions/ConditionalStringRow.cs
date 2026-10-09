using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ConditionalStringRow : OneOfBase<IfStringRow, CoalesceStringRow>
{
    public ConditionalStringRow(IfStringRow value)
        : this((OneOf<IfStringRow, CoalesceStringRow>)value) { }

    public ConditionalStringRow(CoalesceStringRow value)
        : this((OneOf<IfStringRow, CoalesceStringRow>)value) { }

    private ConditionalStringRow(OneOf<IfStringRow, CoalesceStringRow> input)
        : base(input) { }
}
