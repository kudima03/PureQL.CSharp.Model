using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.TotalExpressions;

/// <summary>PureQL <c>uuid@total</c>.</summary>
public readonly union UuidTotal(IfUuidTotal, CoalesceUuidTotal, LiteralUuid, ParamUuid);
