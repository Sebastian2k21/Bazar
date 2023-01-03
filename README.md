# Bazar

## Wymagania

Aby korzystać z aplikacji wymagany jest pakiet [ASP.NET Core 6](https://dotnet.microsoft.com/en-us/download/dotnet/6.0).

## Instalacja

1. Wypakuj pliki projektu do wybranego katalogu.
2. Otwórz terminal w katalogu Bazar.
3. Zainstaluj narzędzie dotnet df za pomocą polecenia: ``dotnet tool install --global dotnet-ef``
4. Stwórz bazę danych: ``dotnet ef database update``
5. Uruchom aplikację używając: ``dotnet run``

## Dane logowania

Strona znajduje się pod adresem: ``https://localhost:7046``, aby zalogować się należy wybrać z menu nawigacyjnego opcję Login i wprowadzić następujące dane logowania:
	Login: admin@bazar.pl
	Hasło: Admin123

## Instrukcja użytkownika


### Rejestracja

Aby skorzystać z aplikacji należy wykorzystać przygotowane dane logowania lub stworzyć nowego użytkownika za pomocą formularza rejestracji wchodząc pod adres ``https://localhost:7046/Register``

![Formularz rejestracji](/register.png)


### Logowanie
Logowanie znajduje się pod adresem: ``https://localhost:7046/Login``. Należy podać adres email użytkownika i hasło.

![Formularz logowania](/login.png)

### Dodawanie przedmiotu
Dodawanie przedmiotu znajduje się w zakładce ``Sell Item`` pod adresem: ``https://localhost:7046/Item/Create``. Użytkownik powinien być zalogowany. Należy obowiązkowo wprowadzić: nazwe, cenę oraz kategorię. 

![Formularz dodawania przedmiotu](/additem.png)

Dodany przedmiot można podejrzeć w zakładce ``My Items`` pod adresem ``https://localhost:7046/Item/MyItems``. 

![Widok dodanych przedmiotów](/myitems.png)

### Wyszukiwanie i kupowanie przedmiotów

Aby zobaczyć aktualne oferty przedmiotów należy wejść w zakładkę ``Items`` znajdującą się pod adresem ``https://localhost:7046/Item``. Dostępna jest wyszukiwarka w której można dokonać filtowania przedmiotów na podstawie nazw oraz przedziału cenowego.

![Widok przedmiotów](/items.png)

Aby dokonać zakupu należy wybrać z listy interesujący przedmiot i po przejściu na stronę szczegółów wcisnąć przycisk ``Buy now``.


![Widok szczegółów przedmiotu](/details.png)

Po kliknięciu w przycisk w kolejnej stronie należy wypełnić szczegóły zamówienia takie jak: imię nazwisko zamawiającego, adres dostawy, email, telefon, komentarz do sprzedawcy, metoda płatności i sposób wysyłki.

![Widok szczegółów zamówienia](/order.png)

Po kliknięciu w przycisk ``Buy Now!`` zamówienie zostaje potwierdzone a przedmiot można odszukać w zakładce My Orders pod adresem: ``https://localhost:7046/Order``.

![Widok szczegółów zatwierdzonego zamówienia](/myorders.png)



### Panel Admina

Aby skorzystać z panelu admina należy skorzystać z zakładki ``Admin Panel`` znajdującej się pod adresem:  ``https://localhost:7046/Admin``. Dostęp do panelu jest możliwy tylko dla konta z uprawnieniami administratora. 

![Widok panelu admina](/admin.png)