using PureQL.CSharp.Model.Keys;
using PureQL.CSharp.Model.Literals;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>declares.boolean.nullable@group</c>.</summary>
public readonly union DeclaresBooleanNullableGroup(
    AsBooleanBooleanNullableGroup,
    AsNullableBooleanNullableGroup,
    TryAsBooleanGroup,
    IfBooleanNullableGroup,
    CoalesceBooleanNullableGroup,
    NullIfEqualBooleanNullableGroup,
    GreatestBooleanNullableGroup,
    LeastBooleanNullableGroup,
    MinBooleanNullableGroup,
    MaxBooleanNullableGroup,
    FirstBooleanNullableGroup,
    LastBooleanNullableGroup,
    PercentileDiscreteBooleanNullableGroup,
    ModeBooleanNullableGroup,
    LiteralBooleanNullable,
    ParamBooleanNullable,
    KeyBooleanNullable
);
