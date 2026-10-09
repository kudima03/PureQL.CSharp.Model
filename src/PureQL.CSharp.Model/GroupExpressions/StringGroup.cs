using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class StringGroup
    : OneOfBase<
        KeyString,
        ParamString,
        LiteralString,
        ConcatStringGroup,
        ConditionalStringGroup,
        AggregateStringGroup
    >
{
    public StringGroup(KeyString value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    public StringGroup(ParamString value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    public StringGroup(LiteralString value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    public StringGroup(ConcatStringGroup value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    public StringGroup(ConditionalStringGroup value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    public StringGroup(AggregateStringGroup value)
        : this(
            (OneOf<
                KeyString,
                ParamString,
                LiteralString,
                ConcatStringGroup,
                ConditionalStringGroup,
                AggregateStringGroup
            >)
                value
        )
    { }

    private StringGroup(
        OneOf<
            KeyString,
            ParamString,
            LiteralString,
            ConcatStringGroup,
            ConditionalStringGroup,
            AggregateStringGroup
        > input
    )
        : base(input) { }
}
