using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed record NotRow : IOperator
{
    public NotRow(BooleanRow condition)
    {
        Condition = condition;
    }

    public BooleanRow Condition { get; }

    public IType Type => new TypeBoolean();
}
