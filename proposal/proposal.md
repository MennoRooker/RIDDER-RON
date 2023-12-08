> NAME: Menno Rooker
> ID:   12374962
> DATE: 14-11-2023

# RIDDER RON

_RIDDER RON is a 2D RPG adventure game with turn-based combat where you play as a knight to save your Princess from an evil wizard. Fight your way through different types of enemies and ultimately face the wizard to save the day!_

#### Het doel van dit project

"Wat is het probleem dat jouw project gaat oplossen?"

...verveling.

Dat is redelijk vanzelfsprekend voor een spelletje, maar om precies te zijn wil ik een spel maken dat makkelijk te spelen is op een laptop; iets dat je misschien op een spelletjeswebsite zoals speeleiland.nl of funnygames.nl tegen zou kunnen komen. De doelgroep is iedereen die van games houdt en/of geïnteresseerd is in mijn programmeerproject voor wat voor reden dan ook. Met gameplay van een laag instapniveau is het erg geschikt voor kinderen, maar mensen van alle leeftijden kunnen RIDDER RON spelen. Vooral mensen die vroeger veel 2D GameBoy Advance games zoals Pokémon of Zelda hebben gespeeld zullen wat van deze games kunnen herkennen in het eindproduct van mijn project. 

#### Thema

Het thema van een ridder en tovenaar RPG is best voordehandliggend, namelijk Middeleeuwse Fantasy. Ik heb al wat tilesets en sprites online gevonden die binnen dit thema passen. Eerlijk gezegd denk ik niet dat ik al te veel tijd kwijt wil zijn aan de thematiek, ik geloof dat de sprites en overworld interacties voldoende zullen zijn om het thema effectief naar voren te laten komen, dus dingen zoals ambient lighting van fakkels in een grot en NPC's die de wereld uitbreiden zijn dingen waar ik alleen aan zou beginnen wanneer ik echt tijd over heb. 

#### Scènes

Het is mijn plan om 4 soorten scènes te implementeren:

- Start/End Screen
- Overworld
- Battle Scene
- Inventory/Inspect


Het start- en eindscherm wordt simpelweg een welkomstberichtje met wellicht een thematisch lettertype en een achtergrond, waar de speler op een knop klikt om te beginnen of opnieuw te spelen. De schermen die niet met gameplay te maken hebben wil ik het liefst zo simpel mogelijk houden. Misschien een sprite van het personage waarmee je speelt en van de tovenaar, verder alleen wat tekst in een ouderwets lettertype.

Hieronder is een schets van het startscherm:

![StartScreen](<RIDDER RON Startscherm Schets.jpg>)


Voor de overworld scenes heb ik iets in gedachten dat vergelijkbaar is met Pokémon. Ik wil het liefst dat de speler net als bij Pokémon telkens in het midden van het scherm komt te staan en dat de wereld om de speler heen beweegt. Mijn plan is om de camera dus mee te laten bewegen met de speler. Of dit haalbaar is, weet ik niet. Zo niet dan zal ik met een statische overworld scène moeten werken waar de speler dan van de ene kant van het scherm naar de andere kant beweegt, totdat er geen scherm meer over is en de scène overgaat naar een nieuwe Overworld scène. Op OpenGameArt.org heb ik al wat 2D tiles gevonden en ik denk dat een screenshot van één van de voorbeelden beter schetst wat ik in gedachten heb dan een eigen schets, dus hieronder is de template die ik als referentiekader zal gebruiken:

![Overworld](<RIDDER RON Overworld Schets.png>)


De gevechtsscènes wil ik ook redelijk simpel houden. De speler en de vijand staan in zijprofiel tegenover elkaar een beetje zoals in Swords and Sandals. De speler krijgt de optie om te verdedigen of om aan te vallen en misschien nog wat extra opties zoals speciale aanvallen op geneesmiddelen, die beiden onder 'Magic' vallen. Hoe ik precies deze battle mechanics ga implementeren weet ik nog niet, maar hieronder is alvast een schets van wat ik in gedachten heb:

![Battle Scene](<RIDDER RON Battle Scene Schets.jpg>)


Als laatste wil ik nog een inventory toevoegen als ik daar tijd voor heb. Het is de bedoeling dat de speler voorwerpen verzamelt tijdens het spel en zodoende verder komt met deze items. Ik zal dit als laatste toevoegen, omdat ik overweeg het spel zonder inventory te maken en dit pas te implementeren als de rest van het spel soepel loopt.

![Inventory](<RIDDER RON Inventory Schets.jpg>)

#### Game Mechanics & Scope

Qua game mechanics wil ik het ook graag redelijk simpel houden. Turn-based combat is het belangrijkste om goed te implementeren, dit zie ik als mijn 'core mechanics'. Het bewegen en interacten in de Overworld zal secundair hieraan worden. 

De besturing van mijn spel zal volledig met het toetsenbord worden, voorlopig heb ik de volgende keybinds in gedachten:

- `WASD` movement
- `[SPACE]` = Interact
- `[SHIFT]` = Back/Cancel
- `[TAB]` = Inventory

Zodra de speler zich in een menu zoals de inventory of de battle scène bevindt kan hij/zij met `WASD` door de opties navigeren en met `[SPACE]` om een optie te kiezen. `[TAB]` om de inventory te open vanaf de Overworld en `[SHIFT]` om het menu af te sluiten of een pagina terug te gaan. 

In mijn bespreking van de scènes heb ik al vermeld dat ik waarschijnlijk de meeste tijd kwijt ga zijn om een werkende game te maken die van scènes wisselt wanneer dit de bedoeling is en dat alles wat er omheen komt tweede prioriteit heeft. Gelukkig heb ik al wat handige tutorials gevonden online om in ieder geval een begin te kunnen maken aan mijn game. De bron waar ik het meeste van mijn informatie van ga halen is de YouTube playlist [Make A Game Like Pokémon In Unity](https://www.youtube.com/watch?v=_Pm16a18zy8&list=PLLf84Zj7U26kfPQ00JVI2nIoozuPkykDX&ab_channel=GameDevExperiments) van [Game Dev Experiments](https://www.youtube.com/@GameDevExperiments).

Deze playlist heeft alles wat ik nodig heb om de opbouw van mijn eigen game op te baseren. Natuurlijk zal ik de nodige aanpassingen maken qua thema, vechten en progressie, maar het helpt erg dat ik al een voorbeeld heb voor een werkende 2D RPG in Unity.

De maker van deze playlist maakt zelf ook gebruik van OpenGameArt.com voor zijn sprites en tiles, verder ben ik natuurlijk van plan andere bronnen zoals stackoverflow of reddit te gebruiken op punten waarop ik vastloop. Wat ik aan externe componenten nodig ga hebben weet ik nu nog niet. De kans is groot dat ik tijdens mijn project een aantal bibliotheken moet importeren om bepaalde game mechanics mogelijk te maken, maar dit zie ik tegen die tijd wel.

#### Moeilijkheden

Ik vermoed dat hetgeen dat mij de meeste problemen gaat geven de mechanics van het spel zullen zijn. Interacten met de omgeving, correcte collisions, schade aanbrengen aan tegenstanders en op de juiste momenten van scène wisselen met de correcte progressie. Dit zijn allemaal dingen die het meest uitdagend zijn en waar ik verreweg de meeste tijd aan kwijt zal zijn. 