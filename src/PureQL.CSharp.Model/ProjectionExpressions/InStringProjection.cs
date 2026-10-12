using PureQL.CSharp.Model.Lists;
using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.ProjectionExpressions;

public sealed record InStringProjection : IOperator
{
    public InStringProjection(StringNullableProjection operand, ListString list)
    {
        Operand = operand;
        List = list;
    }

    public StringNullableProjection Operand { get; }

    public ListString List { get; }

    public IType Type => new TypeBoolean();
}
