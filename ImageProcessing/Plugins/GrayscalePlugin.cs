using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class GrayscalePlugin : IImagePlugin
    {
        public string Name => "Grayscale";
        public bool RequiresValue => false;

        public string Invoke(string image, string? value = null)
        {
            return $"{image} converted to grayscale";
        }
    }
}
