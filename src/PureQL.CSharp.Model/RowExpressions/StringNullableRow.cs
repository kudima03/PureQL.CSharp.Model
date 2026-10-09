using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class StringNullableRow
    : OneOfBase<
        FieldAsStringNullable,
        ParamAsStringNullable,
        LiteralAsStringNullable,
        ConcatStringNullableRow,
        ConditionalStringNullableRow
    >
{
    public StringNullableRow(FieldAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public StringNullableRow(ParamAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public StringNullableRow(LiteralAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public StringNullableRow(ConcatStringNullableRow value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    public StringNullableRow(ConditionalStringNullableRow value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableRow,
                ConditionalStringNullableRow
            >)
                value
        )
    { }

    private StringNullableRow(
        OneOf<
            FieldAsStringNullable,
            ParamAsStringNullable,
            LiteralAsStringNullable,
            ConcatStringNullableRow,
            ConditionalStringNullableRow
        > input
    )
        : base(input) { }
}
