using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime.nullable@group</c>.</summary>
public sealed record AsDatetimeStringDatetimeNullableGroup : IOperator
{
    public AsDatetimeStringDatetimeNullableGroup(DeclaresStringNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableGroup Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
