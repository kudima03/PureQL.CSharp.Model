using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

/// <summary>PureQL <c>literal.uuid.nullable</c>.</summary>
public sealed record LiteralUuidNullable : ILiteral
{
    public IType Type => new TypeUuidNullable();
}
