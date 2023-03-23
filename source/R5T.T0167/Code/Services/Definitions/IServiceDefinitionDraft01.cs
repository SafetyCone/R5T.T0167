using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.T0167
{
    /// <summary>
    /// A service implementation type for use in testing <see cref="DraftServiceDefinitionMarkerAttribute"/>-based code survey.
    /// </summary>
	[DraftServiceDefinitionMarker]
    public interface IServiceDefinitionDraft01 : IDraftServiceDefinition
    {
        
    }
}