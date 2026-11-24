using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asNullable.datetime.nullable@group</c>.</summary>
public sealed record AsNullableDatetimeNullableGroup : IOperator
{
    public AsNullableDatetimeNullableGroup(DatetimeGroup operand)
    {
        Operand = operand;
    }

    public DatetimeGroup Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
