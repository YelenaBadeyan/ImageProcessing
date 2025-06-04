using ImageProcessing.Interfaces;

namespace ImageProcessing.Plugins
{
    public class BlurPlugin : IImagePlugin
    {
        public string Name => "Blur";
        public bool RequiresValue => true;

        public string Invoke(string image, string? value = null)
        {
            return $"{image} blurred with intensity {value}";
        }
    }
}
