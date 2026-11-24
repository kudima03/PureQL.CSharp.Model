using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>tryAsInteger@group</c>.</summary>
public sealed record TryAsIntegerGroup : IOperator
{
    public TryAsIntegerGroup(StringNullableGroup operand)
    {
        Operand = operand;
    }

    public StringNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
