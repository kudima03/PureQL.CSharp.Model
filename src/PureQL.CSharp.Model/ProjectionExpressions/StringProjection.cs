using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class StringProjection
    : OneOfBase<
        FieldString,
        ParamString,
        LiteralString,
        ConcatStringProjection,
        ConditionalStringProjection
    >
{
    public StringProjection(FieldString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringProjection,
                ConditionalStringProjection
            >)
                value
        )
    { }

    public StringProjection(ParamString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringProjection,
                ConditionalStringProjection
            >)
                value
        )
    { }

    public StringProjection(LiteralString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringProjection,
                ConditionalStringProjection
            >)
                value
        )
    { }

    public StringProjection(ConcatStringProjection value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringProjection,
                ConditionalStringProjection
            >)
                value
        )
    { }

    public StringProjection(ConditionalStringProjection value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringProjection,
                ConditionalStringProjection
            >)
                value
        )
    { }

    private StringProjection(
        OneOf<
            FieldString,
            ParamString,
            LiteralString,
            ConcatStringProjection,
            ConditionalStringProjection
        > input
    )
        : base(input) { }
}
