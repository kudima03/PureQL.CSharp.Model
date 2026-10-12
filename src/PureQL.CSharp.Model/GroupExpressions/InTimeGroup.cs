using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InTimeGroup : IOperator
{
    public InTimeGroup(TimeNullableGroup operand, ListTime list)
    {
        Operand = operand;
        List = list;
    }

    public TimeNullableGroup Operand { get; }

    public ListTime List { get; }

    public IType Type => new TypeBoolean();
}
