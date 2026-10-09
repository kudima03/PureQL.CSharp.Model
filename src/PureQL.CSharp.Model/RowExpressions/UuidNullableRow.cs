using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

public sealed class UuidNullableRow
    : OneOfBase<
        FieldAsUuidNullable,
        ParamAsUuidNullable,
        LiteralAsUuidNullable,
        ConditionalUuidNullableRow
    >
{
    public UuidNullableRow(FieldAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public UuidNullableRow(ParamAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public UuidNullableRow(LiteralAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    public UuidNullableRow(ConditionalUuidNullableRow value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableRow
            >)
                value
        )
    { }

    private UuidNullableRow(
        OneOf<
            FieldAsUuidNullable,
            ParamAsUuidNullable,
            LiteralAsUuidNullable,
            ConditionalUuidNullableRow
        > input
    )
        : base(input) { }
}
