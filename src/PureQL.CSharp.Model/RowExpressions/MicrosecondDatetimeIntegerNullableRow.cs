using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>microsecond.datetime.integer.nullable@row</c>.</summary>
public sealed record MicrosecondDatetimeIntegerNullableRow : IOperator
{
    public MicrosecondDatetimeIntegerNullableRow(DeclaresDatetimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableRow Operand { get; }

    public IType Type => new TypeIntegerNullable();
}
