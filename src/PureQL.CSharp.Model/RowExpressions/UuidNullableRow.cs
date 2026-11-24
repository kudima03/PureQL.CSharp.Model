using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>uuid.nullable@row</c>.</summary>
public readonly union UuidNullableRow(
    AsUuidUuidRow,
    IfUuidRow,
    CoalesceUuidRow,
    GreatestUuidRow,
    LeastUuidRow,
    LiteralUuid,
    ParamUuid,
    FieldUuid,
    AsUuidUuidNullableRow,
    AsNullableUuidNullableRow,
    TryAsUuidRow,
    IfUuidNullableRow,
    CoalesceUuidNullableRow,
    NullIfEqualUuidNullableRow,
    GreatestUuidNullableRow,
    LeastUuidNullableRow,
    LiteralUuidNullable,
    ParamUuidNullable,
    FieldUuidNullable
);
