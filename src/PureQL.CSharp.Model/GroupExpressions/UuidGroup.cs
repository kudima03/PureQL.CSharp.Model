using OneOf;
using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class UuidGroup
    : OneOfBase<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup>
{
    public UuidGroup(KeyUuid value)
        : this((OneOf<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup>)value) { }

    public UuidGroup(ParamUuid value)
        : this((OneOf<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup>)value) { }

    public UuidGroup(LiteralUuid value)
        : this((OneOf<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup>)value) { }

    public UuidGroup(ConditionalUuidGroup value)
        : this((OneOf<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup>)value) { }

    private UuidGroup(OneOf<KeyUuid, ParamUuid, LiteralUuid, ConditionalUuidGroup> input)
        : base(input) { }
}
