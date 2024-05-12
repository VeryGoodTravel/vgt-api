# Kontrolery

Kontrolery są odpowiedzialne za obsługę zapytań HTTP. Każdy z nich
realizuje jedną z funkcjonalności aplikacji. W aplikacji znajduje się
5 kontrolerów:

## [Kontroler filtrów](../Controllers/FiltersController.cs)

Odpowiada za obsługę zapytań związanych z pobieraniem dostępnych 
filtrów z innych serwisów. Zwraca informacje takie jak miejsca 
wylotów, lokalizacje hoteli, możliwe konfiguracje uczestników,
oraz zakres dat dostępnych wycieczek.

## [Kontroler logowania](../Controllers/LoginController.cs)

Obsługuje logowanie użytkowników, które musi być wykonane przed
zakupieniem wycieczki. Użytkownik loguje się za pomocą loginu 
w formie uczelnianego indeksu oraz hasła opartego na tym indeksie.
W odpowiedzi na zapytanie zwraca token JWT, który jest generowany 
na podstawie loginu.

## [Kontroler wyszukiwania](../Controllers/SearchController.cs)

Obsługuje zapytania związane z wyszukiwaniem wycieczek. Umożliwia
wyszukiwanie wycieczek na podstawie różnych kryteriów takich jak
miejsce wylotu, miejsce docelowe, zakres dat, liczba i rodzaj
uczestników. Zwracanie wyników jest paginowane, co pozwala na
dynamiczne ładowanie wyników. Zwraca znalezione wycieczki.

## [Kontroler zakupu](../Controllers/PurchaseController.cs)

Odpowiada za obsługę zakupu wycieczek. Uruchamia proces zakupu
wycieczki, który jest realizowany asynchronicznie przez 
pozostałe serwisy. Nasłuchuje na finalizację procesu zakupu i
zwraca odpowiedni status transakcji.

Do zakupu wycieczki wymagane jest podanie tokena JWT, który
został zwrócony podczas logowania. W przypadku nieprawidłowego
tokena zwracany jest odpowiedni błąd.

## [Kontroler oferty](../Controllers/OfferController.cs)

Odpowiada za pobieranie konkretnej oferty. Na podstawie 
identyfikatora oferty zwraca szczegółowe informacje o wycieczce.