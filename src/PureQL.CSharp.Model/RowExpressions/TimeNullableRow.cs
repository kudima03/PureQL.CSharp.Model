using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>time.nullable@row</c>.</summary>
public readonly union TimeNullableRow(
    TimeAddSecondsTimeRow,
    IfTimeRow,
    CoalesceTimeRow,
    LiteralTime,
    ParamTime,
    FieldTime,
    TimeAddSecondsTimeNullableRow,
    IfTimeNullableRow,
    CoalesceTimeNullableRow,
    LiteralTimeNullable,
    ParamTimeNullable,
    FieldTimeNullable
);
