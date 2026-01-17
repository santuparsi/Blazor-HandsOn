namespace DashboaredDemo.Contracts
{
    //Prevents tight coupling
    //Enables multiple widget types
    public interface IWidget
    {
        string Title { get; }
        void Refresh();
    }
}
