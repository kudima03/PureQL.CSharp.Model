using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsTime@group</c>.</summary>
public sealed record TryAsTimeGroup : IOperator
{
    public TryAsTimeGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeTimeNullable();
}
