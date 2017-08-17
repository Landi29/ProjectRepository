ReadMe - A408a

.EXE FILEN KAN FINDES HER: ...A408a\Program\GUIprototype\bin\Debug\GUIprototype.exe

Velkommen til vores ReadMe. For at kunne k�re vores program, kr�ver det, at mapperne er placeret p� de plader, som de var da zip-filen blev ud pakket. Mappernes navne m� ikke �ndres og indholdet i mapperne skal forblive konstant, med undtagelse af nyheder-database, hvor der kan tilf�jes Txt-filer, med filnavn p� formen: DD/MM/YYYY_valfrit_navn. 
Vores program kan k�res ved hj�lp af FakeNewsChecker.exe filen, derudover kan filen FakeNewsChecker.sln �bnes og k�res igennem Visual Studio.
Derudover vil alt kildekode for programmet ogs� kunne findes i FakeNewsChecker.sln mens individuelle projekter kan findes i mappen ClassLibraries.
Vores program funktion, hvor den indl�ser en artikel fra et link virker p� f�lgende hjemmesider:
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
N�r programmet starter f�r man 3 muligheder: 
1.	Update database:  Klikkes denne knap bliver alle artikler, som er over 1 �r gammel, sletter fra databasen sammen med filer med ugyldige navne. 
2.	Remove article: Klikkes denne knap, �bnes en stifinder, som befinder sig i programmets database. Man f�r dermed mulighed for at v�lge den artikel, som skal slettet. N�r en fil v�lges, skal brugeren v�lge om artiklen skal fjernes fra hele databasen eller kun fra specifikke tags. 
3.	Check text: Klikkes denne knap f�r brugeren mulighed for at v�lge en artikel, som sammenlignes med databasen. 
1.	Det kan ske ved at trykke p� open file, hvor brugeren kan v�lge en artikel (Txt fil), som ligger p� brugerens computer. 
2.	Derudover kan man trykke p� web, hvor brugeren f�r mulighed for at indtaste en link til en artikel (virker kun p� ovenst�ende hjemmesider). 
3.	N�r en artikel er valgt, kan der v�lges, hvilke tags, som artiklen skal sammenlignes med, hvis man �nsker at sammenligne med hele databasen v�lges All articels. 
4.	Efter dette v�lger brugeren mellem JaccardSimilarity, CosineSimilarity eller begge, hvorefter resultatet af sammenligningen vil blive vist. 
5.	Brugeren f�r nu mulighed for at tilf�je artiklen til databasen � eller blot g� tilbage til startsiden. Hvis brugeren v�lger at tilf�je artiklen til databasen. Skal der v�lges om brugeren selv vil tilf�je filnavn samt dato eller filnavn og bruge den nuv�rende dato. 
6.	Derefter kan artiklen tilf�jes til et nyt tag og/eller eksisterende tags.
7.	Programmet g�r til derefter tilbage til startsiden. 

Packages: 
HtmlAgilityPack.1.4.9.5
NUnit.3.6.1
NUnit3TestAdapter.3.7.0

Lavet af: 
Aryan Mohammadi Landi, Beinir Ragnuson, Erik Kruuse, Jesper Skovby, Marcus Bach, Patrick Bering Tietze, Simon Dalgas Christensen.
