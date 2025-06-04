namespace ImageProcessing.Interfaces
{
    public interface IImagePlugin
    {
        string Name { get; } 
        bool RequiresValue { get; }
        public string Invoke(string image, string? value = null);
    }

}
