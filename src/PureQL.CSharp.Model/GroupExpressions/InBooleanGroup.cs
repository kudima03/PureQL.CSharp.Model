using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InBooleanGroup : IOperator
{
    public InBooleanGroup(BooleanNullableGroup operand, ListBoolean list)
    {
        Operand = operand;
        List = list;
    }

    public BooleanNullableGroup Operand { get; }

    public ListBoolean List { get; }

    public IType Type => new TypeBoolean();
}
