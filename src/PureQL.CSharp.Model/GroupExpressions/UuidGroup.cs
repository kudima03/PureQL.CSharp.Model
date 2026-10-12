using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class UuidGroup
    : OneOfBase<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup, AggregateUuidGroup>
{
    public UuidGroup(KeyUuid value)
        : this(
            (OneOf<
                KeyUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidGroup,
                AggregateUuidGroup
            >)
                value
        )
    { }

    public UuidGroup(ParamUuid value)
        : this(
            (OneOf<
                KeyUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidGroup,
                AggregateUuidGroup
            >)
                value
        )
    { }

    public UuidGroup(LiteralUuid value)
        : this(
            (OneOf<
                KeyUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidGroup,
                AggregateUuidGroup
            >)
                value
        )
    { }

    public UuidGroup(ConditionalUuidGroup value)
        : this(
            (OneOf<
                KeyUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidGroup,
                AggregateUuidGroup
            >)
                value
        )
    { }

    public UuidGroup(AggregateUuidGroup value)
        : this(
            (OneOf<
                KeyUuid,
                ParamUuid,
                LiteralUuid,
                ConditionalUuidGroup,
                AggregateUuidGroup
            >)
                value
        )
    { }

    private UuidGroup(
        OneOf<
            KeyUuid,
            ParamUuid,
            LiteralUuid,
            ConditionalUuidGroup,
            AggregateUuidGroup
        > input
    )
        : base(input) { }
}
