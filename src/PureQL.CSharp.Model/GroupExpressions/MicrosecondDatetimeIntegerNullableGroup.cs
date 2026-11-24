using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer.nullable@group</c>.</summary>
public sealed record MicrosecondDatetimeIntegerNullableGroup : IOperator
{
    public MicrosecondDatetimeIntegerNullableGroup(DeclaresDatetimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
