# R5T.T0167
All instance marker types in one library.


This presents some difficulties, specifically for:

* Razor components
* Windows Forms
* WPF

I could have just have plain types that have the given marker attributes, but for added "realism" it would be better if these types *were* actually Windows Forms or Razor Components.

This means that the goal of having *one* (1) library with all marker types might be challenging.

?: What do I need to have Razor components in a project?
A: 1) the project SDK must be Microsoft.NET.Sdk.Razor (to engage the Razor component editor), and 2) the project must include a package reference to Microsoft.AspNetCore.Components.Web.

?: What do I need to have Windows Forms in a project?
A: 1) Have the Project <PropertyGroup> element: <UseWindowsForms>true<UseWindowsForms>, and 2) Use a "-windows" <TargetFramework>


## Not Included

T0064.T001 - ServiceAggregation, etc.
T0082 - IConfigurationSource marker attributes.
T0118 - Service test fixture marker attributes.

T:R5T.T0137.ContextDefinitionMarkerAttribute
T:R5T.T0137.ContextImplementationMarkerAttribute
T:R5T.T0137.ContextTypeMarkerAttribute
T:R5T.T0137.DraftContextTypeMarkerAttribut

Obsolete?

T:R5T.T0131.ConstantsMarkerAttribute
T:R5T.T0131.DraftConstantsMarkerAttribute

Obsolete:

TODO

* ServiceAggregation?