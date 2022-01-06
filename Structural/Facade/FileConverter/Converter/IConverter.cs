namespace DesignPattern.Structural.Facade.FileConverter.Converter
{
    internal interface IConverter
    {
        public void Convert(string FileName, string From, string To);
    }
}
