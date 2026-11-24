using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>declares.uuid.nullable@total</c>.</summary>
public readonly union DeclaresUuidNullableTotal(
    AsUuidUuidNullableTotal,
    AsNullableUuidNullableTotal,
    TryAsUuidTotal,
    IfUuidNullableTotal,
    CoalesceUuidNullableTotal,
    NullIfEqualUuidNullableTotal,
    GreatestUuidNullableTotal,
    LeastUuidNullableTotal,
    MinUuidNullableTotal,
    MaxUuidNullableTotal,
    FirstUuidNullableTotal,
    LastUuidNullableTotal,
    PercentileDiscreteUuidNullableTotal,
    ModeUuidNullableTotal,
    LiteralUuidNullable,
    ParamUuidNullable
);
