using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asDatetime.string.datetime.nullable@row</c>.</summary>
public sealed record AsDatetimeStringDatetimeNullableRow : IOperator
{
    public AsDatetimeStringDatetimeNullableRow(DeclaresStringNullableRow operand)
    {
        Operand = operand;
    }

    public DeclaresStringNullableRow Operand { get; }

    public IType Type => new TypeDatetimeNullable();
}
