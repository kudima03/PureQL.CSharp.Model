using OneOf;
using PureQL.CSharp.Model.ArrayReturnings;
using PureQL.CSharp.Model.Returnings;

namespace PureQL.CSharp.Model;

public sealed class SelectExpression : OneOfBase<SingleValueReturning, ArrayReturning>
{
    public SelectExpression(SingleValueReturning returning, string? alias = null)
        : this((OneOf<SingleValueReturning, ArrayReturning>)returning, alias) { }

    public SelectExpression(ArrayReturning returning, string? alias = null)
        : this((OneOf<SingleValueReturning, ArrayReturning>)returning, alias) { }

    private SelectExpression(
        OneOf<SingleValueReturning, ArrayReturning> input,
        string? alias
    )
        : base(input)
    {
        Alias = alias;
    }

    public string? Alias { get; }
}
