# PHP en HTML paginas
## index.html
Pagina die de gebruiker ziet.
## login.php
Pagina waarop ingelogd kan worden.
## register.php
Pagina waar nieuwe gebruikers zich kunnen registeren.
## bestellingen.php
Pagina waar gebruikers bestellingen kunnen doen.

##


# Database plannen
## Klanten
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT(11)		| Id van de klant									|
| hash		 	| VARCHAR(32)	| Unique hash voor van de klant						|
| voornaam 		| VARCHAR(64) 	| Voornaam van de klant								|
| achternaam 	| VARCHAR(64) 	| Achternaam van de klant 							|
| registratie 	| DATETIME	 	| Registratie datum									|
| email		 	| VARCHAR(100) 	| Email van de klant	 							|
| wachtwoord 	| VARCHAR(100) 	| Wachtwoord van de klant (hashed)					|
| bestellingen	| INT	 		| Aantal bestellingen dat de klant heeft gemaakt 	|
| spaarputen	| INT			| Aantal spaarputen dat de klant heeft verzameld	|
| actief		| BOOLEAN		| Geeft aan of de zijn account heeft geactiveerd	|
| banned		| BOOLEAN		| Geeft aan of de gebruiker gebant is				|

## Pizzas
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van de pizza									|
| naam	 		| VARCHAR(64) 	| Naam van de pizza									|
| prijs		 	| DECIMAL	 	| Prijs van de pizza	 							|
| voorraad	 	| INT		 	| Aantal pizzas in de voorraad.						|

## Bestellingen
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van de bestelling								|
| klant	 		| INT		 	| Id van de klant									|
| bestelling    | TEXT          | Bestelling in text formaat                        |
| afhalen		| BOOLEAN	 	| Als de klant de pizzas wil afhalen				|
| adres			| VARCHAR(255)  | Adres van de klant als hij het wil afhalen		|
| totaalprijs   | DECIMAL       | Totale prijs van de bestelling                    |