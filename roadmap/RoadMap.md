# Database plannen
## Klanten
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van de klant									|
| voornaam 		| VARCHAR(64) 	| Voornaam van de klant								|
| achternaam 	| VARCHAR(64) 	| Achternaam van de klant 							|
| registratie 	| DATETIME	 	| Registratie datum									|
| email		 	| VARCHAR(64) 	| Email van de klant	 							|
| wachtwoord 	| VARCHAR(64) 	| Wachtwoord van de klant (hashed)					|
| bestellingen	| INT	 		| Aantal bestellingen dat de klant heeft gemaakt 	|
| spaarputen	| INT			| Aantal spaarputen dat de klant heeft verzameld	|
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