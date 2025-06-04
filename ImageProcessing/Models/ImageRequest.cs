namespace ImageProcessing.Models
{
    public class ImageRequest
    {
        public string ImageId { get; set; } = string.Empty;
        public List<EffectRequest> Effects { get; set; } = new();
    }
}
