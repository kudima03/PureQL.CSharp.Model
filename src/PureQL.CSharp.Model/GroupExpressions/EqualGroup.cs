using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class EqualGroup
    : OneOfBase<
        EqualDecimalGroup,
        EqualStringGroup,
        EqualBooleanGroup,
        EqualDateGroup,
        EqualTimeGroup,
        EqualDatetimeGroup,
        EqualUuidGroup
    >
{
    public EqualGroup(EqualDecimalGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualStringGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualBooleanGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualDateGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualTimeGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualDatetimeGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    public EqualGroup(EqualUuidGroup value)
        : this(
            (OneOf<
                EqualDecimalGroup,
                EqualStringGroup,
                EqualBooleanGroup,
                EqualDateGroup,
                EqualTimeGroup,
                EqualDatetimeGroup,
                EqualUuidGroup
            >)
                value
        )
    { }

    private EqualGroup(
        OneOf<
            EqualDecimalGroup,
            EqualStringGroup,
            EqualBooleanGroup,
            EqualDateGroup,
            EqualTimeGroup,
            EqualDatetimeGroup,
            EqualUuidGroup
        > input
    )
        : base(input) { }
}
