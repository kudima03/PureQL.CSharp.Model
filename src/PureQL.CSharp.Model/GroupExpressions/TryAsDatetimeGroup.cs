using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsDatetime@group</c>.</summary>
public sealed record TryAsDatetimeGroup : IOperator
{
    public TryAsDatetimeGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
