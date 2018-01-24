<?php
    session_start();

    // Error message die in het geval van een error gebruikt kan worden.
    $error_msg = '';
    
    echo($_SERVER['REQUEST_METHOD']);
    if ($_SERVER['REQUEST_METHOD'] == 'POST') 
    {
        // De methode is POST. De gebruiker verstuurt het formulier met verschillende variablen.
        echo("Registering new account...");

        // Creeër de database connectie in het db.php script.
        $mysqli = '';
        require 'db.php';
        
        // Hier halen we alle POST variablen door een filter om te zorgen dat kwade mensen geen MySql injections kunnen uitvoeren.
        $voornaam = $mysqli->escape_string($_POST['voornaam']);
        $achternaam = $mysqli->escape_string($_POST['achternaam']);
        $email = $mysqli->escape_string($_POST['emailnaam']);
        $wachtwoord = $mysqli->escape_string($_POST['wachtwoord']);
        
        
        //CREATE private hash
        //hash password
        //STORE
        //redirect to login.
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- De titel van de website -->
    <title>DRL Pizza | Register</title>
    
    <!-- Charset -->
    <meta charset="utf-8">
    
    <link rel="stylesheet" href="..\theme.css">
    <link rel="stylesheet" href="..\animate.css">
    <link rel="stylesheet" href="forms.css">
    
    <!-- Latest compiled and minified CSS van boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme voor boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript voor boostrap -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body>
    <!-- De wrapper voor het menu aan de bovenkant -->
    <nav class="navbar">
        <!-- De container div die zorgt waarin de boostrap elementen komen. -->
        <div class="container">
            <!-- Word naar links getrokken -->
            <div class="pull-left">
                <ul>
                    <li id="logo"><a href="..\index.html">DRL PIZZAS</a></li>
                </ul>
            </div>
        
            <!-- Word naar rechts getrokken -->
            <div id="center" class="pull-right">
                <!-- Unondered list die de items bevat -->
                <ul>
                    <!-- De <a> word gebruikt om links mee te maken. -->
                    <li><a href="register.php">Registeren</a></li>
                    <li><a href="login.php">Login</a></li>
                </ul>
            </div>
        </div>
    </nav>
    
    <div class="venster">
        <div class="container">
            <div class="loginform">
                <form action="register.php" method="post">
                    <h2 id="header">Registreer</h2>
                    
                    <h4>Voornaam</h4>
                    <input type="text" required id="ftextbox" name="voornaam" placeholder="Voornaam...">
                    <br>
                    <h4>Achternaam</h4>
                    <input type="text" required id="ftextbox" name="achternaam" placeholder="Achternaam...">
                    <br>
                    <h4>Email</h4>
                    <input type="email" required id="ftextbox" name="email" placeholder="Email...">
                    <br>
                    <h4>Wachtwoord</h4>
                    <input type="password" required id="ftextbox" name="wachtwoord" placeholder="Wachtwoord...">
                    <br>
                    <br>
                    <button type="submit" id="fbutton" name="registeer"><span>Registreer</span></button>
                    <br>
                    <br>
                    <p style="width: 30em;text-align: center;"><a style="color: green; width: 30em;" href="login.php">Al een account? Klik hier om in te loggen.</a></p>
                </form>
            </div>
        </div>
    </div>
</body>
</html>