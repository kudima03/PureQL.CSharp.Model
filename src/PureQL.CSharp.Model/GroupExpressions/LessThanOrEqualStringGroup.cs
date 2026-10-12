using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

public sealed record LessThanOrEqualStringGroup : IOperator
{
    public LessThanOrEqualStringGroup(StringNullableGroup left, StringNullableGroup right)
    {
        Left = left;
        Right = right;
    }

    public StringNullableGroup Left { get; }

    public StringNullableGroup Right { get; }

    public IType Type => new TypeBoolean();
}
