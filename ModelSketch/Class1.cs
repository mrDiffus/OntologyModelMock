using System;
using System.Linq;
using System.Collections.Generic;
namespace ModelSketch
/*
Assumption:
    The goal is to create a portable digital twin represenation of "A thing", "It's function" and "It's location". Aspects of "The Thing". 
    More Aspects might be added. None of the base three will be removed. 

Premises:
    The graphs will alway be strict directed tree graphs. DAGS or Cyclical graphs will result in a single node having two names / ID's.
    Aspects are Product, Function and location. More might be added.
    There is a pre-defined finite list of Aspects nodes in an Aspect might relate to via Semantic relations. 

Reqs
    Find path if exists between two given Products. 

Assumed flow
    Data is posted -> Naivly serialized to internal model -> Model is subjected to semantic verification. -> Throw
                                                                                                            -> Woho!
*/ 

{
    //Rough as boulders sketch. Ignore most if not all base types.
    
}
