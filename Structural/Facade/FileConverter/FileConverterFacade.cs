using DesignPattern.Structural.Facade.FileConverter.Compress;
using DesignPattern.Structural.Facade.FileConverter.Compress.Types;
using DesignPattern.Structural.Facade.FileConverter.Converter;
using DesignPattern.Structural.Facade.FileConverter.Converter.Audio;
using DesignPattern.Structural.Facade.FileConverter.Converter.Video;
using DesignPattern.Structural.Facade.FileConverter.FileScanner;
using DesignPattern.Structural.Facade.FileConverter.FileScanner.Audio;
using DesignPattern.Structural.Facade.FileConverter.FileScanner.Video;
using DesignPattern.Structural.Facade.FileConverter.Normalizer;
using DesignPattern.Structural.Facade.FileConverter.Normalizer.Audio;
using DesignPattern.Structural.Facade.FileConverter.Normalizer.Video;

namespace DesignPattern.Structural.Facade.FileConverter
{
    internal class FileConverterFacade
    {
        private string FileName { get; set; }
        private bool IsAudio = true;
        private IFileScanner fileScanner;
        private INormalizer normalizer;
        private IConverter converter;
        private ICompress compress;

        public FileConverterFacade(string fileName)
        {
            this.FileName = fileName;
            DetectType();
            Load();
        }
        private void DetectType()
        {
            string FileNameExtension = Path.GetExtension(this.FileName);
            if (FileNameExtension == AudioTypes.AudioMP3.ToString() || FileNameExtension == AudioTypes.AudioAA.ToString() || FileNameExtension == AudioTypes.AudioAAC.ToString())
            {
                fileScanner = new Mp3Scanner();
                normalizer = new AudioNormalizer();
                converter = new AudioConverter();
                compress = new ZipCompress();
            }
            else
            {
                fileScanner = new Mp4Scanner();
                normalizer = new VideoNormalizer();
                converter = new VideoConverter();
                compress = new GzCompress();
                IsAudio = false;
            }
        }

        private void Load()
        {
            try
            {
                fileScanner.Scan();
                normalizer.Normalize(this.FileName);
            }
            catch (Exception e)
            {
                throw new CorruptedFileException($"This file is corrupted and can not be converted\n {e.Message}");
            }

        }

        public void DoConvert()
        {
            if (IsAudio)
            {
                converter.Convert(this.FileName, Path.GetExtension(this.FileName), AudioTypes.AudioAA.ToString());
            }
            else
            {
                converter.Convert(this.FileName, Path.GetExtension(this.FileName), VideoTypes.VideoMP4.ToString());
            }
            compress.Compress(this.FileName);
        }

    }
}
