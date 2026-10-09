using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class EqualProjection
    : OneOfBase<
        EqualDecimalProjection,
        EqualStringProjection,
        EqualBooleanProjection,
        EqualDateProjection,
        EqualTimeProjection,
        EqualDatetimeProjection,
        EqualUuidProjection
    >
{
    public EqualProjection(EqualDecimalProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualStringProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualBooleanProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualDateProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualTimeProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualDatetimeProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    public EqualProjection(EqualUuidProjection value)
        : this(
            (OneOf<
                EqualDecimalProjection,
                EqualStringProjection,
                EqualBooleanProjection,
                EqualDateProjection,
                EqualTimeProjection,
                EqualDatetimeProjection,
                EqualUuidProjection
            >)
                value
        )
    { }

    private EqualProjection(
        OneOf<
            EqualDecimalProjection,
            EqualStringProjection,
            EqualBooleanProjection,
            EqualDateProjection,
            EqualTimeProjection,
            EqualDatetimeProjection,
            EqualUuidProjection
        > input
    )
        : base(input) { }
}
