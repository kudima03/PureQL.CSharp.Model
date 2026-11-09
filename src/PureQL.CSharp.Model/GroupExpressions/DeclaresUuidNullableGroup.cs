using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.uuid.nullable@group</c>.</summary>
public readonly union DeclaresUuidNullableGroup(
    IfUuidNullableGroup,
    CoalesceUuidNullableGroup,
    MinUuidNullableGroup,
    MaxUuidNullableGroup,
    LiteralUuidNullable,
    ParamUuidNullable,
    KeyUuidNullable
);
