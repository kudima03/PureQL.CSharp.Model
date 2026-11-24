using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.datetime.string.nullable@row</c>.</summary>
public sealed record AsStringDatetimeStringNullableRow : IOperator
{
    public AsStringDatetimeStringNullableRow(DeclaresDatetimeNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresDatetimeNullableRow Operand { get; }

    public IType Type => new TypeStringNullable();
}
