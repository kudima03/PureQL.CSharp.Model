using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.time.string.nullable@row</c>.</summary>
public sealed record AsStringTimeStringNullableRow : IOperator
{
    public AsStringTimeStringNullableRow(DeclaresTimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresTimeNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
