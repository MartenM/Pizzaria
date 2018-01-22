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
| banned		| BOOLEAN		| Geeft aan of de gebruiker gebant is				|

## Producten
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van het product								|
| naam	 		| VARCHAR(64) 	| Naam van het product								|
| prijs		 	| DECIMAL	 	| Prijs van het product	 							|
| voorraad	 	| INT		 	| Aantal prodcuten in de voorraad					|

## Bestellingen
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van de bestelling								|
| klant	 		| INT		 	| Id van de klant									|

## BestellingenInhoud
|Sleutel  		| type 			| beschrijving |
|---		 	| --- 			| --- |
| id		 	| INT			| Id van de bestelling								|
| klant	 		| INT		 	| Id van de klant									|
| pizza	 		| INT		 	| Id van de pizza									|

Note: In deze tabel staan de producten die besteld zijn bij de bestellingen.