using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class UuidNullableGroup
    : OneOfBase<
        KeyAsUuidNullable,
        ParamAsUuidNullable,
        LiteralAsUuidNullable,
        ConditionalUuidNullableGroup
    >
{
    public UuidNullableGroup(KeyAsUuidNullable value)
        : this(
            (OneOf<
                KeyAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableGroup
            >)
                value
        )
    { }

    public UuidNullableGroup(ParamAsUuidNullable value)
        : this(
            (OneOf<
                KeyAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableGroup
            >)
                value
        )
    { }

    public UuidNullableGroup(LiteralAsUuidNullable value)
        : this(
            (OneOf<
                KeyAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableGroup
            >)
                value
        )
    { }

    public UuidNullableGroup(ConditionalUuidNullableGroup value)
        : this(
            (OneOf<
                KeyAsUuidNullable,
                ParamAsUuidNullable,
                LiteralAsUuidNullable,
                ConditionalUuidNullableGroup
            >)
                value
        )
    { }

    private UuidNullableGroup(
        OneOf<
            KeyAsUuidNullable,
            ParamAsUuidNullable,
            LiteralAsUuidNullable,
            ConditionalUuidNullableGroup
        > input
    )
        : base(input) { }
}
