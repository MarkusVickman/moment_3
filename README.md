# ASP.NET - Entity Framework Core
## Moment 3, dt191g - Webbutveckling med .NET

Webbplatsen heter "Lend a book" och där går det att låna böcker. Sidan är tänk för att användas av personal på exempelvis ett litet bibliotek. Webbplatsen innehåller 4 tabeller(modeller) med data för användare, boklån, böcker och författare. Routes, crud samt tabeller och formulär skapades automatiskt utifrån modellerna till databasen. Ändringar har gjort för att lägga till sök för alla tabeller. Routes är ändrade för boklån så att de även ändrar värde för hur många böcker som finns i lager.

Uppgiften uppfyller grundkraven samt krav för överbetyg. 

### Tabell - bok
Tabellen bok har relation till författare samt till boklån. Tabellen innehåller FK = författar id.

### Tabell - författare
Tabellen författare har relation till böcker.

### Tabell - boklån
Tabellen boklån har relation till bok samt till användare. Tabellen innehåller två FK, ena är bok id och andra är användar id.

### Tabell - användare
Tabellen användare har relation till boklån.

## Grundkrav
* Att ni använder models, controller och vyer.
* Att ni använder Entity Framework Core.
* Att ni använder er av code first när ni skapar databasen.
* Du ska kunna skapa, redigera, uppdatera och ta bort information om böckerna.
* Ni ska dels kunna få upp alla böcker, samt klicka för att få fram information om en specifik bok. 
* Förstå hur hur ni ska navigera och modifiera data i en ansluten DBMS (Databas-server).
* Förstå hur klassen DbContext används och hur klasser ärver från denna klass.


## Överbetygkrav
* Ni ska kunna låna ut böcker till användare och er databas ska hålla reda på vem som har boken och datum när detta lån gjordes.
* Ni ska skapa minst en till tabell för att spara data om den som lånar boken.
* Skapa en sökfunktion för böcker. 

#### Markus Vickman 
Student-id: mavi2302
