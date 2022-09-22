using System.IO;
using System.Threading.Tasks;

namespace EsetAssignment.Services
{
    /// <summary>
    /// Base class for file service.
    /// </summary>
    public abstract class BaseFileService
    {
        protected BaseFileService()
        {

        }

        /// Load file by current path.
        /// </summary>
        /// <param name="path">File path.</param>
        public abstract void LoadFileByPath(string path);

        /// <summary>
        /// Save and write new content to file.
        /// </summary>
        /// <param name="path">Save file name.</param>
        public abstract Task WriteToFile(string path);
    }
}
