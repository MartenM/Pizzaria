<?php
    /*
        Dit PHP bestand kan worden toegevoegd aan paginas waar de gebruiker zeker weten moet zijn ingelogd.
        Wanneer de gebruiker niet ingelogd is in dit geval word deze doorverwezen naar de login pagina (login.php).
    */

    // Wanneer de variable 'ingelogt' empty is dan is de gebruiker niet ingelogt.
    if(empty($_SESSION['ingelogt'])){
        // Stuur door naar de login.php pagina.
        header("Location: login.php");
        exit;
    } else if($_SESSION['ingelogt'] == false){
        // Stuur door naar de login.php pagina.
        header("Location: login.php");
        exit;
    }

    // Wanneer beide If statements false zijn, is de gebruiker ingelogd.
?>