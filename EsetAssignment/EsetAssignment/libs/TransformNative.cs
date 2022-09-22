namespace EsetAssignment.libs;

internal static class TransformNative
{
    [System.Runtime.InteropServices.DllImport("Transform.dll")]
    public static extern int Transform(int input);
}


