using OneOf;

namespace PureQL.CSharp.Model.BooleanOperations;

public sealed class BooleanOperator : OneOfBase<AndOperator, OrOperator, NotOperator>
{
    public BooleanOperator(AndOperator field)
        : this((OneOf<AndOperator, OrOperator, NotOperator>)field) { }

    public BooleanOperator(OrOperator field)
        : this((OneOf<AndOperator, OrOperator, NotOperator>)field) { }

    public BooleanOperator(NotOperator parameter)
        : this((OneOf<AndOperator, OrOperator, NotOperator>)parameter) { }

    private BooleanOperator(OneOf<AndOperator, OrOperator, NotOperator> input)
        : base(input) { }
}
