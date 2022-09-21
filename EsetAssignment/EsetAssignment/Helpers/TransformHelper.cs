namespace EsetAssignment.Helpers;

internal static class TransformHelper
{
    [System.Runtime.InteropServices.DllImport("Transform.dll")]
    public static extern int Transform(int input);
}
