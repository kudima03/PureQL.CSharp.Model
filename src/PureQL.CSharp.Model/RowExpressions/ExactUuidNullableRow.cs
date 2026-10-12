using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class ExactUuidNullableRow
    : OneOfBase<
        FieldUuidNullable,
        ParamUuidNullable,
        LiteralUuidNullable,
        ConditionalUuidNullableRow
    >
{
    public ExactUuidNullableRow(FieldUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public ExactUuidNullableRow(ParamUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public ExactUuidNullableRow(LiteralUuidNullable value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public ExactUuidNullableRow(ConditionalUuidNullableRow value)
        : this(
            (OneOf<
                FieldUuidNullable,
                ParamUuidNullable,
                LiteralUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    private ExactUuidNullableRow(
        OneOf<
            FieldUuidNullable,
            ParamUuidNullable,
            LiteralUuidNullable,
            ConditionalUuidNullableRow
        > input
    )
        : base(input) { }
}
