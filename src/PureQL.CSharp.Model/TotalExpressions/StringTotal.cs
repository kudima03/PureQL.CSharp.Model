using OneOf;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

public sealed class StringTotal
    : OneOfBase<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal>
{
    public StringTotal(ParamString value)
        : this(
            (OneOf<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal>)
                value
        )
    { }

    public StringTotal(LiteralString value)
        : this(
            (OneOf<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal>)
                value
        )
    { }

    public StringTotal(ConcatStringTotal value)
        : this(
            (OneOf<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal>)
                value
        )
    { }

    public StringTotal(ConditionalStringTotal value)
        : this(
            (OneOf<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal>)
                value
        )
    { }

    private StringTotal(
        OneOf<ParamString, LiteralString, ConcatStringTotal, ConditionalStringTotal> input
    )
        : base(input) { }
}
