using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class NotEqualProjection
    : OneOfBase<
        NotEqualDecimalProjection,
        NotEqualStringProjection,
        NotEqualBooleanProjection,
        NotEqualDateProjection,
        NotEqualTimeProjection,
        NotEqualDatetimeProjection,
        NotEqualUuidProjection
    >
{
    public NotEqualProjection(NotEqualDecimalProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualStringProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualBooleanProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualDateProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualTimeProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualDatetimeProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    public NotEqualProjection(NotEqualUuidProjection value)
        : this(
            (OneOf<
                NotEqualDecimalProjection,
                NotEqualStringProjection,
                NotEqualBooleanProjection,
                NotEqualDateProjection,
                NotEqualTimeProjection,
                NotEqualDatetimeProjection,
                NotEqualUuidProjection
            >)
                value
        )
    { }

    private NotEqualProjection(
        OneOf<
            NotEqualDecimalProjection,
            NotEqualStringProjection,
            NotEqualBooleanProjection,
            NotEqualDateProjection,
            NotEqualTimeProjection,
            NotEqualDatetimeProjection,
            NotEqualUuidProjection
        > input
    )
        : base(input) { }
}
