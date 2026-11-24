using PureQL.CSharp.Model.Fields;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.ProjectionExpressions;

/// <summary>PureQL <c>declares.string.nullable@projection</c>.</summary>
public readonly union DeclaresStringNullableProjection(
    ConcatStringNullableProjection,
    UpperStringNullableProjection,
    LowerStringNullableProjection,
    FoldCaseStringNullableProjection,
    NormalizeStringNullableProjection,
    RemoveDiacriticsStringNullableProjection,
    TrimStringNullableProjection,
    TrimStartStringNullableProjection,
    TrimEndStringNullableProjection,
    SubstringStringNullableProjection,
    ReplaceStringNullableProjection,
    SplitPartStringNullableProjection,
    PadStartStringNullableProjection,
    PadEndStringNullableProjection,
    RepeatStringNullableProjection,
    ReverseStringNullableProjection,
    ExtractRegexProjection,
    ReplaceRegexStringNullableProjection,
    AsStringDecimalStringNullableProjection,
    AsStringBooleanStringNullableProjection,
    AsStringDateStringNullableProjection,
    AsStringTimeStringNullableProjection,
    AsStringDatetimeStringNullableProjection,
    AsStringUuidStringNullableProjection,
    AsNullableStringNullableProjection,
    IfStringNullableProjection,
    CoalesceStringNullableProjection,
    NullIfEqualStringNullableProjection,
    GreatestStringNullableProjection,
    LeastStringNullableProjection,
    MinStringNullableProjection,
    MaxStringNullableProjection,
    FirstStringNullableProjection,
    LastStringNullableProjection,
    PercentileDiscreteStringNullableProjection,
    ModeStringNullableProjection,
    PreviousStringNullableProjection,
    NextStringNullableProjection,
    LiteralStringNullable,
    ParamStringNullable,
    FieldStringNullable
);
