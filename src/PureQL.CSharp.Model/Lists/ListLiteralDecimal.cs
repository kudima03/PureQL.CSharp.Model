using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralDecimal : ILiteral
{
    public ListLiteralDecimal(IEnumerable<decimal> value)
    {
        Value = value;
    }

    public IEnumerable<decimal> Value { get; }

    public IType Type => new TypeDecimalList();
}
