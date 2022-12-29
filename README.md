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

Aby skorzystać z aplikacji należy wykorzystać przygotowane dane logowania lub stworzyć nowego użytkownika za pomocą formularza rejestracji wchodząc pod adres ``https://localhost:7046/Register``

![Formularz rejestracji](/register.png)