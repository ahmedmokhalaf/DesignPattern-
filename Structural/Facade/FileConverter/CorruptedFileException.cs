namespace DesignPattern.Structural.Facade.FileConverter
{
    public class CorruptedFileException : Exception
    {
        public CorruptedFileException(string? message) : base(message)
        {
        }
    }
}
