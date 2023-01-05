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

## Opis projektu

### Wyszukiwanie przedmiotów

Dowolny użytkownik może zobaczyć aktualne oferty przedmiotów. Należy wejść w zakładkę ``Items`` znajdującą się pod adresem ``https://localhost:7046/Item``. Dostępna jest wyszukiwarka w której można dokonać filtowania przedmiotów na podstawie nazw oraz przedziału cenowego.

![Widok przedmiotów](/items.png)

### Rejestracja

Dowolny użytkownik ma dostęp do strony ``https://localhost:7046/Register`` na której w formularzu zostawia dane logowania: adres email i hasło. 

![Formularz rejestracji](/register.png)

Po wysłaniu formularza w przypadku ustawienia poprawnych danych użytkownik jest przenoszony do strony z formularzem logowania ``https://localhost:7046/Login``.

### Logowanie

Do strony z logowaniem: ``https://localhost:7046/Login`` ma dostęp dowolny użytkownik. Należy podać adres email użytkownika i hasło.

![Formularz logowania](/login.png)

Po przesłaniu formularza w przypadku podania poprawnych danych logowania użytkownik jest przenoszony pod adres: ``https://localhost:7046/`` gdzie znajduje się strona powitalna aplikacji.

### Dodawanie przedmiotu
Użytkownik posiadjący konto w serwisie może dodawać nowe oferty. Wystawienie przedmiotu znajduje się w zakładce ``Sell Item`` pod adresem: ``https://localhost:7046/Item/Create``. Należy obowiązkowo wprowadzić: nazwe, cenę oraz kategorię. 

![Formularz dodawania przedmiotu](/additem.png)

Po przesłaniu formularza użytkownik jest przekierowany na stronę z aktualnie dostępnymi przedmiotami: ``https://localhost:7046/Item``.
Dodany przedmiot można podejrzeć w zakładce ``My Items`` pod adresem ``https://localhost:7046/Item/MyItems``. 

![Widok dodanych przedmiotów](/myitems.png)

Przykładowo pod adresem ``https://localhost:7046/Item/Details/5`` znajduje się oferta przedmiotu o ID nr 5.

### Kupowanie przedmiotów

Kupowanie jest dostępne tylko dla użytkownika posiadającego konto w serwisie. Aby dokonać zakupu należy wybrać z listy  ``https://localhost:7046/Item`` interesujący przedmiot (np. wejść pod adres ``https://localhost:7046/Item/Details/5``) i po przejściu na stronę szczegółów wcisnąć przycisk ``Buy now``.


![Widok szczegółów przedmiotu](/details.png)

Po kliknięciu w przycisk użytkownik jest przekierowany pod adres ``https://localhost:7046/Order/Buy/5`` (przykład dla przedmiotu o ID 5).
Na kolejnej stronie należy wypełnić szczegóły zamówienia takie jak: imię nazwisko zamawiającego, adres dostawy, email, telefon, komentarz do sprzedawcy, metoda płatności i sposób wysyłki.

![Widok szczegółów zamówienia](/order.png)

Po kliknięciu w przycisk ``Buy Now!`` zamówienie zostaje potwierdzone. Użytkownik jest przekierowany do strong: ````https://localhost:7046/Item``. Przedmiot można odszukać w zakładce My Orders pod adresem: ``https://localhost:7046/Order``, która jest dostępna dla osób posiadających konto w serwisie.

![Widok szczegółów zatwierdzonego zamówienia](/myorders.PNG)

### Panel Admina

Dostęp do panelu administratora jest dostępny tylko dla użytkowników posiadających konto w serwisie z uprawieniami aministratora.
Aby skorzystać z panelu należy skorzystać z zakładki ``Admin Panel`` znajdującej się pod adresem:  ``https://localhost:7046/Admin``.

![Widok panelu admina](/admin.PNG)