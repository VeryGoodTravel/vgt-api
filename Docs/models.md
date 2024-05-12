# Modele

Modele to obiekty, które reprezentują dane w systemie. 
Wszystkie z nich zostały zdefiniowane przy pomocy JSON Schema,
a następnie półautomatycznie przetłumaczone na klasy C#.
Dzięki nim ustandaryzowana została komunikacja między frontendem,
a backendem.

## [Envelope](../Models/Envelope/Envelope.cs)

Jest to klasa opakowująca, która zawiera w sobie obiekt danych,
który jest zwracany w odpowiedzi na zapytanie HTTP. Do każdej 
odpowiedzi dodawane są dodatkowe informacje, takie jak status, 
ewentualne błędy, czy też timestamp.

## [Wspólne](../Models/Common)

Modele, które są wykorzystywane zarówno w zapytaniach, jak i
odpowiedziach. Są to na przykład modele reprezentujące zakres dat,
uczestników wycieczki, czy też lokalizacje.

## [Zapytania](../Models/Requests)

Modele, które są wykorzystywane w zapytaniach. Pozwalają one na
automatyczne walidowanie danych wejściowych oraz ich przekształcenie
na obiekty C#. Są ściśle związane z kontrolerami.

## [Odpowiedzi](../Models/Responses)

Modele, które są wykorzystywane w odpowiedziach. Przez 
ustandaryzowanie odpowiedzi, frontend może łatwo przetwarzać
dane zwracane przez backend. Są ściśle związane z kontrolerami.
