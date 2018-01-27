<?php
    session_start();
    session_unset();
    session_destroy();
    
    echo("<!-- Succesvol uitgelogd -->");

    header("Location: ..\index.html");
?>