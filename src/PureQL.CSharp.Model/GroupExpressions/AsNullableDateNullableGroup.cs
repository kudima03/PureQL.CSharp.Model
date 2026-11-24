using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.date.nullable@group</c>.</summary>
public sealed record AsNullableDateNullableGroup : IOperator
{
    public AsNullableDateNullableGroup(DateGroup operand)
    {
        Operand = operand;
    }

    public DateGroup Operand { get; }

    public IType Type => new TypeDateNullable();
}
