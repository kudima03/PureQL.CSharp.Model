using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class LessThanOrEqualGroup
    : OneOfBase<
        LessThanOrEqualDecimalGroup,
        LessThanOrEqualStringGroup,
        LessThanOrEqualBooleanGroup,
        LessThanOrEqualDateGroup,
        LessThanOrEqualTimeGroup,
        LessThanOrEqualDatetimeGroup,
        LessThanOrEqualUuidGroup
    >
{
    public LessThanOrEqualGroup(LessThanOrEqualDecimalGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualStringGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualBooleanGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualDateGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualTimeGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualDatetimeGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public LessThanOrEqualGroup(LessThanOrEqualUuidGroup value)
        : this(
            (OneOf<
                LessThanOrEqualDecimalGroup,
                LessThanOrEqualStringGroup,
                LessThanOrEqualBooleanGroup,
                LessThanOrEqualDateGroup,
                LessThanOrEqualTimeGroup,
                LessThanOrEqualDatetimeGroup,
                LessThanOrEqualUuidGroup
            >)
                value
        )
    { }

    private LessThanOrEqualGroup(
        OneOf<
            LessThanOrEqualDecimalGroup,
            LessThanOrEqualStringGroup,
            LessThanOrEqualBooleanGroup,
            LessThanOrEqualDateGroup,
            LessThanOrEqualTimeGroup,
            LessThanOrEqualDatetimeGroup,
            LessThanOrEqualUuidGroup
        > input
    )
        : base(input) { }
}
