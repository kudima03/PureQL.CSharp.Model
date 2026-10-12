using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class GreaterThanOrEqualGroup
    : OneOfBase<
        GreaterThanOrEqualDecimalGroup,
        GreaterThanOrEqualStringGroup,
        GreaterThanOrEqualBooleanGroup,
        GreaterThanOrEqualDateGroup,
        GreaterThanOrEqualTimeGroup,
        GreaterThanOrEqualDatetimeGroup,
        GreaterThanOrEqualUuidGroup
    >
{
    public GreaterThanOrEqualGroup(GreaterThanOrEqualDecimalGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualStringGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualBooleanGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualDateGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualTimeGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualDatetimeGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    public GreaterThanOrEqualGroup(GreaterThanOrEqualUuidGroup value)
        : this(
            (OneOf<
                GreaterThanOrEqualDecimalGroup,
                GreaterThanOrEqualStringGroup,
                GreaterThanOrEqualBooleanGroup,
                GreaterThanOrEqualDateGroup,
                GreaterThanOrEqualTimeGroup,
                GreaterThanOrEqualDatetimeGroup,
                GreaterThanOrEqualUuidGroup
            >)
                value
        )
    { }

    private GreaterThanOrEqualGroup(
        OneOf<
            GreaterThanOrEqualDecimalGroup,
            GreaterThanOrEqualStringGroup,
            GreaterThanOrEqualBooleanGroup,
            GreaterThanOrEqualDateGroup,
            GreaterThanOrEqualTimeGroup,
            GreaterThanOrEqualDatetimeGroup,
            GreaterThanOrEqualUuidGroup
        > input
    )
        : base(input) { }
}
