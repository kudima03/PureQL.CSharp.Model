using OneOf;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed class SelectExpression
    : OneOfBase<
        BooleanReturning,
        NumberReturning,
        StringReturning,
        DateReturning,
        TimeReturning,
        DateTimeReturning,
        UuidReturning
    >
{
    public SelectExpression(BooleanReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(NumberReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(StringReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(DateReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(TimeReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(DateTimeReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    public SelectExpression(UuidReturning returning, string? alias = null)
        : this(
            (OneOf<
                BooleanReturning,
                NumberReturning,
                StringReturning,
                DateReturning,
                TimeReturning,
                DateTimeReturning,
                UuidReturning
            >)
                returning,
            alias
        )
    { }

    private SelectExpression(
        OneOf<
            BooleanReturning,
            NumberReturning,
            StringReturning,
            DateReturning,
            TimeReturning,
            DateTimeReturning,
            UuidReturning
        > input,
        string? alias
    )
        : base(input)
    {
        Alias = alias;
    }

    public string? Alias { get; }
}
