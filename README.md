# IMF - AAS

A project converting between pure IMF format and IMF compliant AAS format. Taking as input aasx files.

## Open questions

* Bør `ModelElement` være abstract eller dupliserer vi felles properties RDLType, Attribute og Id, flere?
* Relasjon er modellert med referanse til AspectObject x 2 (source og target), men hvordan går man fra AspectObject til relasjon, feks for å finne parent til AspectObject? Iterere gjennom alle relasjonene?
* Skal hasParent-relasjon være spesiell på noen måte?
