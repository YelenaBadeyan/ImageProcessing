using ImageProcessing.Models;

namespace ImageProcessing.Services
{
    public class ImageProcessor
    {
        private readonly PluginManager _pluginManager;

        public ImageProcessor(PluginManager pluginManager)
        {
            _pluginManager = pluginManager;
        }

        public string ProcessImage(ImageRequest request)
        {
            var image = $"Image {request.ImageId}";

            foreach (var effect in request.Effects)
            {
                var plugin = _pluginManager.GetPlugin(effect.PluginName);

                if (plugin == null)
                {
                    image += $" -> [Skipped: Plugin '{effect.PluginName}' not found]";
                    continue;
                }

                if (plugin.RequiresValue && string.IsNullOrEmpty(effect.Value))
                {
                    image += $" -> [Skipped: '{plugin.Name}' requires a value]";
                    continue;
                }

                image = plugin.Invoke(image, effect.Value);
            }

            return image;
        }
    }
}
