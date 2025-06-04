using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class ResizePlugin : IImagePlugin
    {
        public string Name => "Resize";
        public bool RequiresValue => true;

        public string Invoke(string image, string? value = null)
        {
            return $"{image} resized to {value}px";
        }
    }
}
