# Dokumentacja

## Działanie aplikacji

Aplikacja odpowiada za komunikację za główną komunikację pomiędzy
klientem a serwisami udostępnianymi przez serwer. Klient 
do komunikacji z serwerem używa protokołu HTTP oraz architektury
REST.

## Struktura aplikacji

### [Kontrolery](controllers.md)

### [Serwisy](services.md)

### [Modele](models.md)

## Budowanie ofert

Jako aplikacja odpowiedzialna za komunikację z serwisami, aplikacja
jest odpowiedzialna za budowanie ofert wycieczek. Oferty są budowane
na podstawie informacji zwracanych przez serwisy hoteli i lotów.

Do obu serwisów wysyłane są zapytania, z odpowiednimi filtrami,
wynikającymi z zapytania klienta. Następnie, na podstawie odpowiedzi
z serwisów, z których dostajemy informacje o dostępnych hotelach dla
danej konfiguracji osób i dat, oraz dostępnych lotach z wybranych 
lotnisk do wybranych lokalizacji, budowana są oferty wycieczek.
Ceny zwracane przez serwisy są sumowane, a następnie cena jest 
powiększana o marżę serwisu.

Indywidualne oferty są identyfikowane przez unikalny
identyfikator. Kiedy użytkownik chce zobaczyć szczegóły oferty,
identyfikator jest przekształcany na odpowiednie parametry zapytania
do serwisów, a następnie zwracane są szczegóły oferty.

## Autoryzacja

Aplikacja korzysta z autoryzacji opartej na tokenach JWT. Token jest
generowany podczas logowania, a następnie przekazywany w zapytaniu
o zakup wycieczki. Token jest walidowany przez serwer, a w przypadku,
gdy token jest nieprawidłowy, zwracany jest odpowiedni błąd.