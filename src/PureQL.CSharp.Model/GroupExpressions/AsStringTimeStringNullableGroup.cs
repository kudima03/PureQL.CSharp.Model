using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.time.string.nullable@group</c>.</summary>
public sealed record AsStringTimeStringNullableGroup : IOperator
{
    public AsStringTimeStringNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
