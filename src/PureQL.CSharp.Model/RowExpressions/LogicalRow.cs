using OneOf;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class LogicalRow : OneOfBase<AndRow, OrRow, NotRow>
{
    public LogicalRow(AndRow value)
        : this((OneOf<AndRow, OrRow, NotRow>)value) { }

    public LogicalRow(OrRow value)
        : this((OneOf<AndRow, OrRow, NotRow>)value) { }

    public LogicalRow(NotRow value)
        : this((OneOf<AndRow, OrRow, NotRow>)value) { }

    private LogicalRow(OneOf<AndRow, OrRow, NotRow> input)
        : base(input) { }
}
