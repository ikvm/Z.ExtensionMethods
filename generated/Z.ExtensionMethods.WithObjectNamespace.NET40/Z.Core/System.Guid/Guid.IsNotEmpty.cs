using Z.ExtensionMethods.ObjectExtensions;

namespace Z.ExtensionMethods
{

using System;

public static partial class Extensions
{
    /// <summary>A GUID extension method that queries if a not is empty.</summary>
    /// <param name="this">The @this to act on.</param>
    /// <returns>true if a not is empty, false if not.</returns>
    public static bool IsNotEmpty(this Guid @this)
    {
        return @this != Guid.Empty;
    }
}

}