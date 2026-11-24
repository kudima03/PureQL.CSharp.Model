using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>asNullable.time.nullable@total</c>.</summary>
public sealed record AsNullableTimeNullableTotal : IOperator
{
    public AsNullableTimeNullableTotal(TimeTotal operand)
    {
        Operand = operand;
    }

    public TimeTotal Operand { get; }

    public IType Type => new TypeTimeNullable();
}
