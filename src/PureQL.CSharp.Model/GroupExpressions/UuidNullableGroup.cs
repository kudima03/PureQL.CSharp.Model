using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>uuid.nullable@group</c>.</summary>
public readonly union UuidNullableGroup(
    AsUuidUuidGroup,
    IfUuidGroup,
    CoalesceUuidGroup,
    GreatestUuidGroup,
    LeastUuidGroup,
    MinUuidGroup,
    MaxUuidGroup,
    FirstUuidGroup,
    LastUuidGroup,
    PercentileDiscreteUuidGroup,
    ModeUuidGroup,
    LiteralUuid,
    ParamUuid,
    KeyUuid,
    AsUuidUuidNullableGroup,
    AsNullableUuidNullableGroup,
    TryAsUuidGroup,
    IfUuidNullableGroup,
    CoalesceUuidNullableGroup,
    NullIfEqualUuidNullableGroup,
    GreatestUuidNullableGroup,
    LeastUuidNullableGroup,
    MinUuidNullableGroup,
    MaxUuidNullableGroup,
    FirstUuidNullableGroup,
    LastUuidNullableGroup,
    PercentileDiscreteUuidNullableGroup,
    ModeUuidNullableGroup,
    LiteralUuidNullable,
    ParamUuidNullable,
    KeyUuidNullable
);
