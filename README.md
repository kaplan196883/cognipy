# CogniPy - Easy Semantic Technology for Python

Originally released and maintained by [Cognitum Services S.A.](https://www.cognitum.eu) - the creator of [FluentEditor](https://www.cognitum.eu/Semantics/FluentEditor/) allowing use Controlled Natural Language for Ontology development.

The package allows for Reasoning, exploration of RDF/OWL, Fluent Editor CNL files, performs reasoning with OWL/RL Reasoner (Jena) as well as allows using SPARQL Graph queries (Jena)


### Assumptions:

+ If you are on Mac or Linux You MUST have [mono installed](https://www.mono-project.com/) on your system.
+ Assuming Python is installed on your system.
+ Tested with Anaconda
+ Tested on MacOS, Winows and Linux (UBuntu)

Install `cognipy` on your system using :

```
pip install cognipy
```

### Building new version

```
nuget restore cognipy\CogniPy.sln
msbuild cognipy\CogniPy.sln /t:Rebuild /p:Configuration=Release /p:Platform="any cpu"
python setup.py bdist_wheel
python -m twine upload dist/* --verbose
```

### Open Source Libraties this project is build on
1. IKVM
2. CommandLineParser
3. Newtonsoft.JSon
4. ELK - ELK is an ontology reasoner that aims to support the OWL 2 EL profile. See http://elk.semanticweb.org/ for further information.
5. HermiT - HermiT is a conformant OWL 2 DL reasoner that uses the direct semantics. It
supports all OWL2 DL constructs and the datatypes required by the OWL 2 specification.   
6. Apache Jena -   Jena is a Java framework for building semantic web applications. It provides  tools and Java libraries to help you to develop semantic web and linked-data apps, tools and servers. 
7. OWLAPI