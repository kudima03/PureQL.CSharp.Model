using PureQL.CSharp.Model.Types;

namespace PureQL.CSharp.Model.SelectItems;

public interface ISelectItem
{
    public string Alias { get; }

    public IType Type { get; }
}
