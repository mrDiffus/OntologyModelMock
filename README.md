# IMF - AAS

A project converting between pure IMF format and IMF compliant AAS format. Taking as input aasx files.

## Answered questions

* Bør `ModelElement` være abstract eller dupliserer vi felles properties RDLType, Attribute og Id, flere? **Vi dupliserer i første omgang**
* Relasjon er modellert med referanse til AspectObject x 2 (source og target), men hvordan går man fra AspectObject til relasjon, feks for å finne parent til AspectObject? Iterere gjennom alle relasjonene? **Vi begynner med en strategi der vi lar `AspectObject` ha en liste med `Relastionship` For å tvinge gjennom hvordan datamodellen skal brukes prøver vi også å fjerne `source` fra `Relastionship`og fjerne `List<Relationship>` fra `AspectModel`**

## Open questions

* Skal hasParent-relasjon være spesiell på noen måte?
* Når vi merger 2 eller flere `AspectModel` vil vi slå sammen `AspectObject` med lik `id`. Hva gjør vi hvis de andre feltene som `RdlType` og `Aspect` er forskjellig?
* Når vi merger 2 eller flere `List<Relationship>` vil vi slå sammen `Relationship` med samme `id`. Hva gjør vi hvis `target` er forskjellig eller hvis vi har relasjon med lik `id` på 2 forskjellige `AspectObject`? 
