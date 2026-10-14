using OneOf;

namespace PureQL.CSharp.Model.Equalities;

public sealed class SingleValueEquality
    : OneOfBase<
        BooleanEquality,
        DateEquality,
        DateTimeEquality,
        NumberEquality,
        StringEquality,
        TimeEquality,
        UuidEquality
    >
{
    public SingleValueEquality(BooleanEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(DateEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(DateTimeEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(NumberEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(StringEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(TimeEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    public SingleValueEquality(UuidEquality equality)
        : this(
            (OneOf<
                BooleanEquality,
                DateEquality,
                DateTimeEquality,
                NumberEquality,
                StringEquality,
                TimeEquality,
                UuidEquality
            >)
                equality
        )
    { }

    private SingleValueEquality(
        OneOf<
            BooleanEquality,
            DateEquality,
            DateTimeEquality,
            NumberEquality,
            StringEquality,
            TimeEquality,
            UuidEquality
        > input
    )
        : base(input) { }
}
