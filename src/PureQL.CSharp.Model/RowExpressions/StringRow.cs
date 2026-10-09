using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class StringRow
    : OneOfBase<
        FieldString,
        ParamString,
        LiteralString,
        ConcatStringRow,
        ConditionalStringRow
    >
{
    public StringRow(FieldString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringRow,
                ConditionalStringRow
            >)
                value
        )
    { }

    public StringRow(ParamString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringRow,
                ConditionalStringRow
            >)
                value
        )
    { }

    public StringRow(LiteralString value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringRow,
                ConditionalStringRow
            >)
                value
        )
    { }

    public StringRow(ConcatStringRow value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringRow,
                ConditionalStringRow
            >)
                value
        )
    { }

    public StringRow(ConditionalStringRow value)
        : this(
            (OneOf<
                FieldString,
                ParamString,
                LiteralString,
                ConcatStringRow,
                ConditionalStringRow
            >)
                value
        )
    { }

    private StringRow(
        OneOf<
            FieldString,
            ParamString,
            LiteralString,
            ConcatStringRow,
            ConditionalStringRow
        > input
    )
        : base(input) { }
}
