Imports MySql.Data.MySqlClient

Public Class DrlDatabase

    ' De properties van dit object.
    Public adres As String
    Public username As String
    Public wachtwoord As String
    Public database As String

    'Deze functie kan gebruikt worden om een nieuwe connectie te maken de database.
    'Dit voorkomt dat de connectie string de hele tijd moet worden getypt.
    Public Function grabConnection() As MySqlConnection
        Dim connection As New MySqlConnection

        Debug.WriteLine($"server={adres}; userid={username}; password={wachtwoord}; database={database}")
        connection.ConnectionString = $"server={adres}; userid={username}; password={wachtwoord}; database={database}"

        Return connection
    End Function


End Class
