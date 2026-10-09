using OneOf;
using PureQL.CSharp.Model.Parameters;

namespace PureQL.CSharp.Model;

public sealed record Pagination
{
    public Pagination(OneOf<long, ParamInteger> skip, OneOf<long, ParamInteger> take)
    {
        Skip = skip;
        Take = take;
    }

    public OneOf<long, ParamInteger> Skip { get; }

    public OneOf<long, ParamInteger> Take { get; }
}
