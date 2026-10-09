using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralIntegerNullable : ILiteral
{
    public IType Type => new TypeIntegerNullable();
}
