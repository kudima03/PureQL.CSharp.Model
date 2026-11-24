using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>startOfSecond.datetime.nullable@row</c>.</summary>
public sealed record StartOfSecondDatetimeNullableRow : IOperator
{
    public StartOfSecondDatetimeNullableRow(DeclaresDatetimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableRow Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
