using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>asString.uuid.string@row</c>.</summary>
public sealed record AsStringUuidStringRow : IOperator
{
    public AsStringUuidStringRow(UuidRow operand)
    {
        Operand = operand;
    }

    public UuidRow Operand { get; }

    public IType Type => new TypeString();
}
