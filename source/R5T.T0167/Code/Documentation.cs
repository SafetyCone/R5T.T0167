using System;

using R5T.T0156;


namespace R5T.T0167
{
	/// <summary>
	/// All instance marker types in one library.
	/// </summary>
	[DocumentationMarker]
	public static class Documentation // : IDocumentationMarker, static classes cannot implement interfaces.
	{
	}

    /// <summary>
    /// All instance marker types in one library.
    /// </summary>
    [DocumentationMarker]
    public class Documentation_Instance : IDocumentationMarker
    {
    }

    /// <summary>
	/// All instance marker types in one library.
	/// </summary>
    [Obsolete("Obsolete documentation.")]
	[DocumentationMarker]
    public static class DocumentationObsolete // : IDocumentationMarker, static classes cannot implement interfaces.
    {
    }

    /// <summary>
    /// All instance marker types in one library.
    /// </summary>
    [Obsolete("Obsolete documentation.")]
    [DocumentationMarker]
    public class DocumentationObsolete_Instance : IDocumentationMarker
    {
    }
}