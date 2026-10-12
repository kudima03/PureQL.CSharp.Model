using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record InStringGroup : IOperator
{
    public InStringGroup(StringNullableGroup operand, ListString list)
    {
        Operand = operand;
        List = list;
    }

    public StringNullableGroup Operand { get; }

    public ListString List { get; }

    public IType Type => new TypeBoolean();
}
