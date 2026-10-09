using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.Lists;

public sealed record ListLiteralBoolean : ILiteral
{
    public ListLiteralBoolean(IEnumerable<bool> value)
    {
        Value = value;
    }

    public IEnumerable<bool> Value { get; }

    public IType Type => new TypeBooleanList();
}
