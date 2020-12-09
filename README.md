## Nog toe te voegen aan applicatie:

- Importeren van .csv bestand met gegevens
- Controleren van input voor het toevoegen aan lijst
- Exporteren van data naar .csv bestand
- Kunnen wijzigen van gegevens in lijst
- Filteren van gegevens in nieuw frame
- Zoekfunctie in console en frame


## Feedback C# OO Programming


#### Kennismaking Visual Studio 2019

- [x] *Aanmaken solution binnen GIT-repository*
- [x] *Eenvoudige consoletoepassing (met invoer gebruiker)*
- [x] *Eenvoudige WinForm toepassing*
- [x] *Een klasse toevoegen*

#### Gebruik GIT

- [x] *Je gebruikt 'atomaire' commits*
- [x] *Je voert voldoende frequent een 'Commit All & Sync' uit.*
- [x] *Je gebruikt zinvolle commit messages*

#### Debugging

--> Nog niet beoordeeld (kan enkel interactief gebeuren)

- [ ] *Code stap voor stap uitvoeren*
- [ ] *Breakpoints*
- [ ] *De waarde van variabelen bekijken tijdens de uitvoering van je programma*

#### Programmeerstijl

- [x] *Huisregels voor programmeerstijl volgen*

* Je volgt niet altijd de regels voor naamgeving.
  * Voor namen van private velden wordt camelCasing gebruikt.
* Gebruik type inference ('var') volgens de conventie uit de stijlregels.
* Gebruik de 'this'-qualifier enkel waar nodig om verwarring te vermijden.
* Hanteer de gevraagde volgorde voor de verschillende onderdelen van je klasse (properties na de velden en voor de constructor).
* Schrijf geen te lange methoden (richtlijn ~20 lijnen).

* Tip: hou rekening met de messages en warnings uit de 'Error List'.

 
#### Exceptions

- [x] *try..catch..finally*
- [x] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*

* `catch (Exception e)` is geen good practice. Probeer meer specifieke excepties op te vangen.
* Een exceptie opvangen om ze dan onmiddellijk weer op te gooien heeft niet zoveel zin.

#### Enumerations

- [x] *Declaratie en gebruik van enum-type*
 
#### Properties

- [x] *Full property (with private backing field)*
- [x] *Auto-implemented property*
- [ ] *Access-modifiers voor Getters en Setters*

* het heeft geen zin in de setter van een 'int' property te testen of 'value' een int is (als dat niet zo is , krijg je al een exception vooraleer je in de setter-code komt).


#### Interpolated strings

- [x] *Interpolated strings*

* Bij een interpolated string is het niet nodig om 'ToString' op te roepen bij het resultaat van een expression tussen accolades.
 

#### Generic collections

--> Nog niet beoordeeld

- [ ] *List<T>*
- [ ] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*

#### Interfaces

--> Nog niet beoordeeld

- [ ] *Interface declaratie*
- [ ] *Interface implementatie*
- [ ] *Interface gebruiken als type*

#### Architectuur van een toepassing - Meerlagenmodel

- [x] *Klasseblibliotheken*
- [x] *Meerlagenmodel - 3lagenmodel*
- [x] *'Loose coupling' - dependency injection*
- [ ] *Interface gebruiken als scheiding tussen architectuurlagen*

* je hebt een goede indeling volgens het 3-lagen model.
* Je gebruikt Dependency injection voor de koppeling tussen presentatie en logica maar niet tussen die logica en de datalaag.
* Bij de koppeling tussen presentatie en logica gebruik je het concrete type 'Inventory' en niet het interface type 'IDataInventory'.
*
#### Bestanden en 'streams'

- [x] *Statische klassen uit 'System.IO'*
- [x] *Streams*
- [x] *Serialisatie*

De Serialisatie naar een Json-bestand is onnodig complex gemaakt.

#### 'Value' en 'Reference' types, cloning van objecten

--> Nog niet beoordeeld

- [ ] *'value' en 'reference' types, 'deep' versus 'shallow' copy*
- [ ] *object cloning*

#### Klassen - klassehiërarchie

- [¨x] *Klasse declaratie - constructoren*
- [ ] *constructor overloading*
- [ ] *Klasse-hiërarchie*

* Je hebt al volwaardige klassedeclaraties
* Je hebt nog geen constructor overloading
* Je hebt nog geen klassehiërarchie



#### Structs

--> Nog niet beoordeeld

- [ ] *Structs*

##### Extension methods

--> Nog niet beoordeeld

- [ ] *Extension method schrijven*
- [ ] *Functioneel gebruik van extension methods*

#### Delegates

--> Nog niet beoordeeld

- [ ] *Delegates*

#### Lambda expressions

--> Nog niet beoordeeld

- [ ] *Lambda expressions*

#### Language Integrated Query (Linq)

--> Nog niet beoordeeld

- [ ] *Linq standard query operator syntax*
- [ ] *Linq method syntax*
- [ ] *Basismethodes voor Linq*

#### Events

--> Nog niet beoordeeld

- [ ] *Event 'Publisher'*
- [ ] *Event 'Consumer'*

#### Concurrent programmatie: Tasks

--> Nog niet beoordeeld

- [ ] *Tasks*
- [ ] *Cross-thread' interactie vanuit een Task met de userinterface*
- [ ] *Exceptions in Tasks*
- [ ] *Parallel loops*
 
#### Concurrent programming: Task synchronisation

--> Nog niet beoordeeld

- [ ] *Lock*
- [ ] *Concurrent/ thread safe collections*

#### Asynchronous programming: async .. await

--> Nog niet beoordeeld

- [ ] *async .. await*

#### (Recursie)

--> Nog niet beoordeeld

- [ ] *Recursie - concept*
- [ ] *Backtracking*

#### (Indexers & Iteratoren)
 
--> Nog niet beoordeeld

- [ ] *Indexers*
- [ ] *Enumeratoren*

#### (Statische klassen, methoden, velden)

--> Nog niet beoordeeld

- [ ] *Statische klassen, methoden, velden*

#### Code Reviews

--> Nog niet beoordeeld

- [ ] *Code reviews*
