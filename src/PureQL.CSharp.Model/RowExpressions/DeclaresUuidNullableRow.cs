using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.uuid.nullable@row</c>.</summary>
public readonly union DeclaresUuidNullableRow(
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
