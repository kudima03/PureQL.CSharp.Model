using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

/// <summary>PureQL <c>cell</c>.</summary>
public readonly union Cell(
    LiteralInteger,
    LiteralIntegerNullable,
    LiteralDecimal,
    LiteralDecimalNullable,
    LiteralString,
    LiteralStringNullable,
    LiteralBoolean,
    LiteralBooleanNullable,
    LiteralDate,
    LiteralDateNullable,
    LiteralTime,
    LiteralTimeNullable,
    LiteralDatetime,
    LiteralDatetimeNullable,
    LiteralUuid,
    LiteralUuidNullable,
    ParamInteger,
    ParamIntegerNullable,
    ParamDecimal,
    ParamDecimalNullable,
    ParamString,
    ParamStringNullable,
    ParamBoolean,
    ParamBooleanNullable,
    ParamDate,
    ParamDateNullable,
    ParamTime,
    ParamTimeNullable,
    ParamDatetime,
    ParamDatetimeNullable,
    ParamUuid,
    ParamUuidNullable
);
