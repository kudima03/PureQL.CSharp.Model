using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.string.nullable</c>.</summary>
public sealed record LiteralStringNullable : ILiteral
{
    public IType Type => new TypeStringNullable();
}
