using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.T0167
{
    /// <summary>
    /// A service implementation type for use in testing <see cref="ServiceDefinitionMarkerAttribute"/>-based code survey.
    /// </summary>
	[ServiceDefinitionMarker]
    public interface IServiceDefinition01 : IServiceDefinition
    {
        
    }
}