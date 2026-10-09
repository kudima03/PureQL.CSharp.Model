using OneOf;
using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class UuidNullableProjection
    : OneOfBase<
        FieldAsUuidNullable,
        ParamAsUuidNullable,
        LiteralAsUuidNullable,
        ConditionalUuidNullableProjection
    >
{
    public UuidNullableProjection(FieldAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableProjection
            >)
                value
        )
    { }

    public UuidNullableProjection(ParamAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableProjection
            >)
                value
        )
    { }

    public UuidNullableProjection(LiteralAsUuidNullable value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableProjection
            >)
                value
        )
    { }

    public UuidNullableProjection(ConditionalUuidNullableProjection value)
        : this(
            (OneOf<
                FieldAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableProjection
            >)
                value
        )
    { }

    private UuidNullableProjection(
        OneOf<
            FieldAsUuidNullable,
            ParamAsUuidNullable,
            LiteralAsUuidNullable,
            ConditionalUuidNullableProjection
        > input
    )
        : base(input) { }
}
