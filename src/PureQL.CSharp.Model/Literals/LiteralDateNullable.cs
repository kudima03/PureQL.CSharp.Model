using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.date.nullable</c>.</summary>
public sealed record LiteralDateNullable : ILiteral
{
    public IType Type => new TypeDateNullable();
}
