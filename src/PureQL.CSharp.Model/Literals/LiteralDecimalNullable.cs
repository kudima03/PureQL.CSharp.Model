using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Literals;

public sealed record LiteralDecimalNullable : ILiteral
{
    public IType Type => new TypeDecimalNullable();
}
