1. Ga naar je xampp install forder (C:\Program Files\xampp ofzo)
2. Ga in je xampp install folder naar \apache\conf
3. Open httpd.conf en ga helemaal naar beneden en voeg de volgende regel toe: `Include "conf/alias/*.conf"`
4. Sla het bestand op en sluit je text editor af.
5. Maak in de conf map een nieuwe map aan met de naam 'alias'.
6. kopieer xampp-alias-dev.conf uit github naar je nieuwe alias map.
7. Open xampp-alias-dev.conf in een text editor.
8. bewerk de directories naar waar je je index.html hebt staan (bijvoorbeeld C:\Users\marten\github\Pizza\site)
