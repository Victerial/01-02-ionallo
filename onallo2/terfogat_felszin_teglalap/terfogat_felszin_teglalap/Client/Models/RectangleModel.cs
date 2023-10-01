namespace terfogat_felszin_teglalap.Client.Models
{
    public class RectangleModel
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double SurfaceArea => Length * Width;
        public double Volume => Length * Width * 1;
    }
}
