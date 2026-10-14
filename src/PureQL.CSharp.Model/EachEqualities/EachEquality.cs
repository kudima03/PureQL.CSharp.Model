using OneOf;

namespace PureQL.CSharp.Model.EachEqualities;

public sealed class EachEquality
    : OneOfBase<
        EachBooleanEquality,
        EachNumberEquality,
        EachStringEquality,
        EachDateEquality,
        EachTimeEquality,
        EachDateTimeEquality,
        EachUuidEquality
    >
{
    public EachEquality(EachBooleanEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachNumberEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachStringEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachDateEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachTimeEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachDateTimeEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    public EachEquality(EachUuidEquality equality)
        : this(
            (OneOf<
                EachBooleanEquality,
                EachNumberEquality,
                EachStringEquality,
                EachDateEquality,
                EachTimeEquality,
                EachDateTimeEquality,
                EachUuidEquality
            >)
                equality
        )
    { }

    private EachEquality(
        OneOf<
            EachBooleanEquality,
            EachNumberEquality,
            EachStringEquality,
            EachDateEquality,
            EachTimeEquality,
            EachDateTimeEquality,
            EachUuidEquality
        > input
    )
        : base(input) { }
}
