using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>uuid@group</c>.</summary>
public readonly union UuidGroup(
    IfUuidGroup,
    CoalesceUuidGroup,
    MinUuidGroup,
    MaxUuidGroup,
    LiteralUuid,
    ParamUuid,
    KeyUuid
);
