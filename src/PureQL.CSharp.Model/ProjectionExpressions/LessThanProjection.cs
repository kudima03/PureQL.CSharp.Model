using OneOf;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed class LessThanProjection
    : OneOfBase<
        LessThanDecimalProjection,
        LessThanStringProjection,
        LessThanBooleanProjection,
        LessThanDateProjection,
        LessThanTimeProjection,
        LessThanDatetimeProjection,
        LessThanUuidProjection
    >
{
    public LessThanProjection(LessThanDecimalProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanStringProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanBooleanProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanDateProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanTimeProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanDatetimeProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    public LessThanProjection(LessThanUuidProjection value)
        : this(
            (OneOf<
                LessThanDecimalProjection,
                LessThanStringProjection,
                LessThanBooleanProjection,
                LessThanDateProjection,
                LessThanTimeProjection,
                LessThanDatetimeProjection,
                LessThanUuidProjection
            >)
                value
        )
    { }

    private LessThanProjection(
        OneOf<
            LessThanDecimalProjection,
            LessThanStringProjection,
            LessThanBooleanProjection,
            LessThanDateProjection,
            LessThanTimeProjection,
            LessThanDatetimeProjection,
            LessThanUuidProjection
        > input
    )
        : base(input) { }
}
