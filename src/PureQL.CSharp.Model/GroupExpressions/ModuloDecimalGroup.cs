using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.GroupExpressions;

/// <summary>PureQL <c>modulo.decimal@group</c>.</summary>
public sealed record ModuloDecimalGroup : IOperator
{
    public ModuloDecimalGroup(DecimalGroup left, DecimalGroup right)
    {
        Left = left;
        Right = right;
    }

    public DecimalGroup Left { get; }

    public DecimalGroup Right { get; }

    public IType Type => new TypeDecimal();
}
