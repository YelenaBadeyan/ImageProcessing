using ImageProcessing.Interfaces;
using ImageProcessing.Plugins;

namespace ImageProcessing.Services
{
    public class PluginManager
    {
        private readonly Dictionary<string, IImagePlugin> _plugins = new();

        public PluginManager()
        {
      
            RegisterPlugin(new ResizePlugin());
            RegisterPlugin(new BlurPlugin());
            RegisterPlugin(new GrayscalePlugin());
        }

        public void RegisterPlugin(IImagePlugin plugin)
        {
            _plugins[plugin.Name.ToLower()] = plugin;
        }

        public IImagePlugin? GetPlugin(string name)
        {
            _plugins.TryGetValue(name.ToLower(), out var plugin);
            return plugin;
        }

        public List<string> GetAvailablePluginNames() => _plugins.Keys.ToList();
    }
}
