using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asString.datetime.string.nullable@group</c>.</summary>
public sealed record AsStringDatetimeStringNullableGroup : IOperator
{
    public AsStringDatetimeStringNullableGroup(DeclaresDatetimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableGroup Operand { get; }

    public IType Type => new TypeStringNullable();
}
