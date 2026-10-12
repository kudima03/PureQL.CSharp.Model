using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InDateGroup : IOperator
{
    public InDateGroup(DateNullableGroup operand, ListDate list)
    {
        Operand = operand;
        List = list;
    }

    public DateNullableGroup Operand { get; }

    public ListDate List { get; }

    public IType Type => new TypeBoolean();
}
