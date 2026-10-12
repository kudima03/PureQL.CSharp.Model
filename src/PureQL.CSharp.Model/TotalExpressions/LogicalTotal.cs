using OneOf;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class LogicalTotal : OneOfBase<AndTotal, OrTotal, NotTotal>
{
    public LogicalTotal(AndTotal value)
        : this((OneOf<AndTotal, OrTotal, NotTotal>)value) { }

    public LogicalTotal(OrTotal value)
        : this((OneOf<AndTotal, OrTotal, NotTotal>)value) { }

    public LogicalTotal(NotTotal value)
        : this((OneOf<AndTotal, OrTotal, NotTotal>)value) { }

    private LogicalTotal(OneOf<AndTotal, OrTotal, NotTotal> input)
        : base(input) { }
}
