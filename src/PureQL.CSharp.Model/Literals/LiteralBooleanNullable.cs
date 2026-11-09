using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.boolean.nullable</c>.</summary>
public sealed record LiteralBooleanNullable : ILiteral
{
    public IType Type => new TypeBooleanNullable();
}
