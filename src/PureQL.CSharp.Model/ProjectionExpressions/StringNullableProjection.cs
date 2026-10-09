using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class StringNullableProjection
    : OneOfBase<
        FieldAsStringNullable,
        ParamAsStringNullable,
        LiteralAsStringNullable,
        ConcatStringNullableProjection,
        ConditionalStringNullableProjection,
        AggregateStringProjection
    >
{
    public StringNullableProjection(FieldAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    public StringNullableProjection(ParamAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    public StringNullableProjection(LiteralAsStringNullable value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    public StringNullableProjection(ConcatStringNullableProjection value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    public StringNullableProjection(ConditionalStringNullableProjection value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    public StringNullableProjection(AggregateStringProjection value)
        : this(
            (OneOf<
                FieldAsStringNullable,
                ParamAsStringNullable,
                LiteralAsStringNullable,
                ConcatStringNullableProjection,
                ConditionalStringNullableProjection,
                AggregateStringProjection
            >)
                value
        )
    { }

    private StringNullableProjection(
        OneOf<
            FieldAsStringNullable,
            ParamAsStringNullable,
            LiteralAsStringNullable,
            ConcatStringNullableProjection,
            ConditionalStringNullableProjection,
            AggregateStringProjection
        > input
    )
        : base(input) { }
}
