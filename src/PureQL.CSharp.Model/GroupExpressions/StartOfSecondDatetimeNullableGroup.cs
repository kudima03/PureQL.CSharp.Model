using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>startOfSecond.datetime.nullable@group</c>.</summary>
public sealed record StartOfSecondDatetimeNullableGroup : IOperator
{
    public StartOfSecondDatetimeNullableGroup(DeclaresDatetimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableGroup Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
