using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>tryAsUuid@row</c>.</summary>
public sealed record TryAsUuidRow : IOperator
{
    public TryAsUuidRow(StringNullableRow operand)
    {
        Operand = operand;
    }

    public StringNullableRow Operand { get; }

    public IType Type => new TypeUuidNullable();
}
