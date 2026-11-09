using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>uuid.nullable@row</c>.</summary>
public readonly union UuidNullableRow(
    IfUuidRow,
    CoalesceUuidRow,
    LiteralUuid,
    ParamUuid,
    FieldUuid,
    IfUuidNullableRow,
    CoalesceUuidNullableRow,
    LiteralUuidNullable,
    ParamUuidNullable,
    FieldUuidNullable
);
