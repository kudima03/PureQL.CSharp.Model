using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record EqualStringGroup : IOperator
{
    public EqualStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
