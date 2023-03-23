using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.T0167
{
    /// <summary>
    /// A service implementation type for use in testing <see cref="ServiceImplementationMarkerAttribute"/>-based code survey.
    /// </summary>
	[ServiceImplementationMarker]
    public class ServiceImplementation01 : IServiceImplementation, IServiceDefinition01
    {
        
    }
}