namespace PureQL.CSharp.Model.Types;

/// <summary>PureQL <c>type.decimalList</c>.</summary>
public sealed record TypeDecimalList : IType
{
    public string Name => "decimalList";

    public bool Nullable => false;
}
