using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>uuid.nullable@total</c>.</summary>
public readonly union UuidNullableTotal(
    IfUuidTotal,
    CoalesceUuidTotal,
    LiteralUuid,
    ParamUuid,
    IfUuidNullableTotal,
    CoalesceUuidNullableTotal,
    MinUuidNullableTotal,
    MaxUuidNullableTotal,
    LiteralUuidNullable,
    ParamUuidNullable
);
