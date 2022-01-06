namespace DesignPattern.Structural.Facade.FileConverter.Normalizer.Video
{
    internal class AudioNormalizer : INormalizer
    {
        public void Normalize(string filename)
        {
            Console.WriteLine($"I am normalizing the file {filename} due to some data corruption\n");
        }
    }
}
