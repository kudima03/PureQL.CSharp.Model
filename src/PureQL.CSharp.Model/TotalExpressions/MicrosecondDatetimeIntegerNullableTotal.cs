using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer.nullable@total</c>.</summary>
public sealed record MicrosecondDatetimeIntegerNullableTotal : IOperator
{
    public MicrosecondDatetimeIntegerNullableTotal(DeclaresDatetimeNullableTotal operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableTotal Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
