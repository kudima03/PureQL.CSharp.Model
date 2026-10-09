using OneOf;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed class NotEqualGroup
    : OneOfBase<
        NotEqualDecimalGroup,
        NotEqualStringGroup,
        NotEqualBooleanGroup,
        NotEqualDateGroup,
        NotEqualTimeGroup,
        NotEqualDatetimeGroup,
        NotEqualUuidGroup
    >
{
    public NotEqualGroup(NotEqualDecimalGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualStringGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualBooleanGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualDateGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualTimeGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualDatetimeGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    public NotEqualGroup(NotEqualUuidGroup value)
        : this(
            (OneOf<
                NotEqualDecimalGroup,
                NotEqualStringGroup,
                NotEqualBooleanGroup,
                NotEqualDateGroup,
                NotEqualTimeGroup,
                NotEqualDatetimeGroup,
                NotEqualUuidGroup
            >)
                value
        )
    { }

    private NotEqualGroup(
        OneOf<
            NotEqualDecimalGroup,
            NotEqualStringGroup,
            NotEqualBooleanGroup,
            NotEqualDateGroup,
            NotEqualTimeGroup,
            NotEqualDatetimeGroup,
            NotEqualUuidGroup
        > input
    )
        : base(input) { }
}
