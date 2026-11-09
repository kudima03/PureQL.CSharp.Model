using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>uuid.nullable@group</c>.</summary>
public readonly union UuidNullableGroup(
    IfUuidGroup,
    CoalesceUuidGroup,
    MinUuidGroup,
    MaxUuidGroup,
    LiteralUuid,
    ParamUuid,
    KeyUuid,
    IfUuidNullableGroup,
    CoalesceUuidNullableGroup,
    MinUuidNullableGroup,
    MaxUuidNullableGroup,
    LiteralUuidNullable,
    ParamUuidNullable,
    KeyUuidNullable
);
