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

* Gebruik de 'this'-qualifier enkel waar nodig om verwarring te vermijden.
* Gebruik type inference ('var') volgens de conventie uit de stijlregels.
* Gebruik betekenisvolle namen voor je variabelen. Het is niet duidelijk waarvoor 'del' in PresentationForm (Corona Viewer) gebruikt zal worden.

 
#### Exceptions

- [x] *try..catch..finally*
- [x] *Je werpt bruikbare exceptions op wanneer je een foutsituatie detecteert die niet lokaal op een beter manier kan afgehandeld worden.*


#### Enumerations

- [x] *Declaratie en gebruik van enum-type*
 
#### Properties

- [x] *Full property (with private backing field)*
- [x] *Auto-implemented property*
- [x] *Access-modifiers voor Getters en Setters*


#### Interpolated strings

- [x] *Interpolated strings*

 

#### Generic collections


- [x] *List<T>*
- [x] *Dictionary<T,T>*
- [ ] *Overzicht andere generic collections*

* Je gebruikt een dictioanry correct maar op een zeer beperkte manier.

#### Interfaces

--> Nog niet beoordeeld

- [ ] *Interface declaratie*
- [ ] *Interface implementatie*
- [ ] *Interface gebruiken als type*

#### Architectuur van een toepassing - Meerlagenmodel

- [x] *Klasseblibliotheken*
- [x] *Meerlagenmodel - 3lagenmodel*
- [x] *'Loose coupling' - dependency injection*
- [x] *Interface gebruiken als scheiding tussen architectuurlagen*


#### Bestanden en 'streams'

- [x] *Statische klassen uit 'System.IO'*
- [x] *Streams*
- [x] *Serialisatie*

#### 'Value' en 'Reference' types, cloning van objecten

- [ ] *'value' en 'reference' types, 'deep' versus 'shallow' copy*
- [x] *object cloning*

* Je hebt al 'Copy' constructors maar nog geen 'deep' copy.
* Je hebt wel een 'DeepCopy' methode in 'Case' maar alle velden van die klasse zijn value-types en daarbij is er dus ook geen sprake van een 'deep' copy.

#### Klassen - klassehiërarchie

- [x] *Klasse declaratie - constructoren*
- [x] *constructor overloading*
- [x] *Klasse-hiërarchie*

* Je hebt een abstracte klasse maar daarin zijn alle members abstract: dan zou je daarvoor beter een interface gebruiken. 
* Je hebt niet 'echt' een klasse-hiërarchie: er is slechts één concrete implementatie van de abstracte klasse 'logic' en in de hudige structuur van je code lijkt het niet logisch te verwachten dat er meerdere implementaties zouden komen. Op die manier heeft die 'hiërarchie' geen meerwaarde voor je toepassing en maakt ze die juist complexer dan toen je met een interface werkte.

#### Structs

- [x] *Structs*

##### Extension methods

- [x] *Extension method schrijven*
- [x] *Functioneel gebruik van extension methods*

#### Delegates

- [x] *Delegates*

* Je 'DataDelegate' in 'LogicHandler' krijgt steeds (enkel) de waarde 'GetTotalsFromData' en heeft zo slechts een beperkt nut.

#### Lambda expressions

--> Nog niet beoordeeld

- [ ] *Lambda expressions*

#### Language Integrated Query (Linq)

- [ ] *Linq standard query operator syntax*
- [x] *Linq method syntax*
- [x] *Basismethodes voor Linq*

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

- [x] *Statische klassen, methoden, velden*


#### Code Reviews

- [x] *Code reviews*
