using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.RowExpressions;

/// <summary>PureQL <c>declares.datetime.nullable@row</c>.</summary>
public readonly union DeclaresDatetimeNullableRow(
    DatetimeAddSecondsDatetimeNullableRow,
    IfDatetimeNullableRow,
    CoalesceDatetimeNullableRow,
    LiteralDatetimeNullable,
    ParamDatetimeNullable,
    FieldDatetimeNullable
);
