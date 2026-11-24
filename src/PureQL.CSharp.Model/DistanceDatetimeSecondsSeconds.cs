using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

public readonly union DistanceDatetimeSecondsSeconds(
    long,
    ParamInteger,
    LiteralDecimal,
    ParamDecimal
);
