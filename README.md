
Vervollständigen Sie das Programm indem Sie diese Schritte abarbeiten:
- Implementieren Sie das Daten-Model für EF Core Code-First:
	- Fügen Sie diese Felder dem AdressEintrag hinzu
		- Geburtstag
		- Telefonnummer
	- Erstellen Sie eine neue Entity zum Erfassen von Adressen und stellen Sie die Relation zum AdressEintrag her. Jeder Eintrag darf mehrere Adressen besitzen
- Erstellen sie eine neue Migration für die Aktualisierung der Datenbank. Die Migration wird automatisch beim Start des Programms angewendet
- Implementieren Sie die Such-Maske:
	- Gesucht wird nur nach dem Namen des AdressEintrag
	- Während der Suche soll die GUI nicht blockieren
	- Die Suche soll abgebrochen werden können
	- Zeigen Sie das Ergebnis der Suche in den Feldern an
- Implementieren Sie ein neues Form zum Erfassen neuer Einträge:
	- Zu den Einträgen sollen alle Daten der Anzeige erfasst werden
	- Die Erfassung soll abgebrochen werden können
