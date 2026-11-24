using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsDate@group</c>.</summary>
public sealed record TryAsDateGroup : IOperator
{
    public TryAsDateGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
