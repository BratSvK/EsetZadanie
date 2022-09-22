using System.Collections.Generic;

namespace EsetAssignment.Services;

/// <summary>
/// File service.
/// </summary>
/// <typeparam name="TDataSet">File data content.</typeparam>
public interface IFileService<TDataSet>
{
    /// <summary>
    /// Loading all content from file.
    /// </summary>
    /// <typeparam name="T">File data content.</typeparam>  
    IEnumerable<TDataSet> GetFileContents();

    /// <summary>
    /// Loading all content from file.
    /// </summary>
    /// <typeparam name="T">File data content.</typeparam>  
    void SetFileContents(IEnumerable<TDataSet> sets);
}

