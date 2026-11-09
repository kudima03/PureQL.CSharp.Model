using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>string@projection</c>.</summary>
public readonly union StringProjection(
    ConcatStringProjection,
    IfStringProjection,
    CoalesceStringProjection,
    MinStringProjection,
    MaxStringProjection,
    LiteralString,
    ParamString,
    FieldString
);
