using EsetAssignment.Helpers;
using EsetAssignment.libs;
using EsetAssignment.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EsetAssignment;

public static class TransfromApp
{
    private const string _inputFileName = "input.txt";
    private const string _outputFileName = "output.txt";

    public static async Task Main(string[] args)
    {
        var fileNumberService = FileNumberService.GetFileService;

        fileNumberService.LoadFileByPath(_inputFileName);
        int[] fileContent = fileNumberService.GetFileContents().ToArray();
        if (fileContent.Length == 0 || fileContent is null)
        {
            return;
        }

        IDictionary<int, int> translateDictionary = fileContent
            .Distinct()
            .ToDictionary(i => i, i => TransformNative.Transform(i));
        fileContent.TransformNumbersInArray(translateDictionary);
        Array.Sort(fileContent);

        fileNumberService.SetFileContents(fileContent);
        await fileNumberService.WriteToFile(_outputFileName);
    }
}
