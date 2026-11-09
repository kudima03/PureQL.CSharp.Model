using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>uuid@row</c>.</summary>
public readonly union UuidRow(
    IfUuidRow,
    CoalesceUuidRow,
    LiteralUuid,
    ParamUuid,
    FieldUuid
);
