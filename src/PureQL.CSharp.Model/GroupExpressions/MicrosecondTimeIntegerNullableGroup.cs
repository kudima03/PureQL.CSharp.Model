using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>microsecond.time.integer.nullable@group</c>.</summary>
public sealed record MicrosecondTimeIntegerNullableGroup : IOperator
{
    public MicrosecondTimeIntegerNullableGroup(DeclaresTimeNullableGroup operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableGroup Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
