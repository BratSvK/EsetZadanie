using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace EsetAssignment.Services
{
    /// <summary>
    /// File service for working with numbers in file.
    /// </summary>
    public class FileNumberService : BaseFileService, IFileService<int>
    {
        private static FileNumberService _instance = new FileNumberService();

        private List<int> _fileContent;

        /// <summary>
        /// Ctor.
        /// </summary>
        private FileNumberService() : base()
        {
            _fileContent = new List<int>();
        }

        public static FileNumberService GetFileService => _instance ??= new FileNumberService();
        
        /// <inheritdoc/>
        public IEnumerable<int> GetFileContents() => _fileContent;

        /// <inheritdoc/>
        public override void LoadFileByPath(string path)
        {
            using StreamReader file = File.OpenText(path);
            while (!file.EndOfStream)
            {
                _fileContent.Add(int.Parse(file.ReadLine()));
            }
        }

        /// <inheritdoc/>
        public void SetFileContents(IEnumerable<int> sets) => _fileContent = sets.ToList();

        /// <inheritdoc/>
        public override async Task WriteToFile(string path)
            => await File.WriteAllLinesAsync(path, _fileContent.Select(i => i.ToString()));
    }
}
