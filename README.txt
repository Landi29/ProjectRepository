ReadMe - A408a

.EXE FILEN KAN FINDES HER: ...A408a\Program\GUIprototype\bin\Debug\GUIprototype.exe

Velkommen til vores ReadMe. For at kunne køre vores program, kræver det, at mapperne er placeret på de plader, som de var da zip-filen blev ud pakket. Mappernes navne må ikke ændres og indholdet i mapperne skal forblive konstant, med undtagelse af nyheder-database, hvor der kan tilføjes Txt-filer, med filnavn på formen: DD/MM/YYYY_valfrit_navn. 
Vores program kan køres ved hjælp af FakeNewsChecker.exe filen, derudover kan filen FakeNewsChecker.sln åbnes og køres igennem Visual Studio.
Derudover vil alt kildekode for programmet også kunne findes i FakeNewsChecker.sln mens individuelle projekter kan findes i mappen ClassLibraries.
Vores program funktion, hvor den indlæser en artikel fra et link virker på følgende hjemmesider:
-	www.bbc.com
-	www.theguardian.com
-	news.sky.com
-	www.washingtonpost.com
-	www.cbsnews.com
-	abcnews.com.co
-	www.breibart.com
-	www.huffingtonpost.com

Filplaceringer: 
Databasen: ...A408a\Program\Nyheder_Database
ClassLibraries: ...A408a\Program\ClassLibraries
Solution: ...A408a\Program\FakeNewsChecker.sIn
.exe: ...A408a\Program\GUIprototype\bin\Debug\GUIprototype.exe

Brugervejledning. 
Når programmet starter får man 3 muligheder: 
1.	Update database:  Klikkes denne knap bliver alle artikler, som er over 1 år gammel, sletter fra databasen sammen med filer med ugyldige navne. 
2.	Remove article: Klikkes denne knap, åbnes en stifinder, som befinder sig i programmets database. Man får dermed mulighed for at vælge den artikel, som skal slettet. Når en fil vælges, skal brugeren vælge om artiklen skal fjernes fra hele databasen eller kun fra specifikke tags. 
3.	Check text: Klikkes denne knap får brugeren mulighed for at vælge en artikel, som sammenlignes med databasen. 
1.	Det kan ske ved at trykke på open file, hvor brugeren kan vælge en artikel (Txt fil), som ligger på brugerens computer. 
2.	Derudover kan man trykke på web, hvor brugeren får mulighed for at indtaste en link til en artikel (virker kun på ovenstående hjemmesider). 
3.	Når en artikel er valgt, kan der vælges, hvilke tags, som artiklen skal sammenlignes med, hvis man ønsker at sammenligne med hele databasen vælges All articels. 
4.	Efter dette vælger brugeren mellem JaccardSimilarity, CosineSimilarity eller begge, hvorefter resultatet af sammenligningen vil blive vist. 
5.	Brugeren får nu mulighed for at tilføje artiklen til databasen – eller blot gå tilbage til startsiden. Hvis brugeren vælger at tilføje artiklen til databasen. Skal der vælges om brugeren selv vil tilføje filnavn samt dato eller filnavn og bruge den nuværende dato. 
6.	Derefter kan artiklen tilføjes til et nyt tag og/eller eksisterende tags.
7.	Programmet går til derefter tilbage til startsiden. 

Packages: 
HtmlAgilityPack.1.4.9.5
NUnit.3.6.1
NUnit3TestAdapter.3.7.0

Lavet af: 
Aryan Mohammadi Landi, Beinir Ragnuson, Erik Kruuse, Jesper Skovby, Marcus Bach, Patrick Bering Tietze, Simon Dalgas Christensen.
