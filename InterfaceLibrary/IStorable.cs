namespace InterfaceLibrary
{
    public interface IStorable
    {
        void SaveState(string fileName);
        void LoadState(string fileName);
    }
}