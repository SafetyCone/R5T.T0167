using System;

using R5T.T0156;


namespace R5T.T0167
{
	/// <summary>
	/// All instance marker types in one library.
	/// </summary>
	[DraftDocumentationMarker]
	public static class DocumentationDraft // : IDocumentationMarker, static classes cannot implement interfaces.
	{
	}

    /// <summary>
    /// All instance marker types in one library.
    /// </summary>
    [DraftDocumentationMarker]
    public class DocumentationDraft_Instance : IDocumentationMarker
    {
    }

    /// <summary>
	/// All instance marker types in one library.
	/// </summary>
    [Obsolete("Obsolete draft documentation.")]
    [DocumentationMarker]
    public static class DocumentationDraftObsolete // : IDocumentationMarker, static classes cannot implement interfaces.
    {
    }

    /// <summary>
    /// All instance marker types in one library.
    /// </summary>
    [Obsolete("Obsolete draft documentation.")]
    [DocumentationMarker]
    public class DocumentationDraftObsolete_Instance : IDocumentationMarker
    {
    }
}