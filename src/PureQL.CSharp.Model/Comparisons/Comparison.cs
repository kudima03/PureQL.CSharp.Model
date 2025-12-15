using OneOf;

namespace PureQL.CSharp.Model.Comparisons;

public sealed class Comparison
    : OneOfBase<
        DateComparison,
        DateTimeComparison,
        NumberComparison,
        StringComparison,
        TimeComparison
    >
{
    public Comparison(DateComparison comparison)
        : this(
            (OneOf<
                DateComparison,
                DateTimeComparison,
                NumberComparison,
                StringComparison,
                TimeComparison
            >)
                comparison
        )
    { }

    public Comparison(DateTimeComparison comparison)
        : this(
            (OneOf<
                DateComparison,
                DateTimeComparison,
                NumberComparison,
                StringComparison,
                TimeComparison
            >)
                comparison
        )
    { }

    public Comparison(NumberComparison comparison)
        : this(
            (OneOf<
                DateComparison,
                DateTimeComparison,
                NumberComparison,
                StringComparison,
                TimeComparison
            >)
                comparison
        )
    { }

    public Comparison(StringComparison comparison)
        : this(
            (OneOf<
                DateComparison,
                DateTimeComparison,
                NumberComparison,
                StringComparison,
                TimeComparison
            >)
                comparison
        )
    { }

    public Comparison(TimeComparison comparison)
        : this(
            (OneOf<
                DateComparison,
                DateTimeComparison,
                NumberComparison,
                StringComparison,
                TimeComparison
            >)
                comparison
        )
    { }

    private Comparison(
        OneOf<
            DateComparison,
            DateTimeComparison,
            NumberComparison,
            StringComparison,
            TimeComparison
        > input
    )
        : base(input) { }
}
