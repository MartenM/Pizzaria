<?php
    // Op de uitlog pagina zorgen we er voor dat alle sessie variablen verwijdert worden.
    session_start();
    session_unset();
    session_destroy();
    
    echo("<!-- Succesvol uitgelogd -->");

    // Daarna sturen we de gebruiker door naar de HomePagina.
    header("Location: ..\index.html");
?>