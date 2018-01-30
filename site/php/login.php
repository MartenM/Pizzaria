<?php
    session_start();
    $error_msg = '';

    // Hier checken we of de gebruiker niet al is ingelogd.
    // Als dit het geval is sturen we hem/haar door naar de profiel.php pagina.
    if(!empty($_SESSION['ingelogt'])){
        if($_SESSION['ingelogt'] == true){
            header("Location: profiel.php");
        }
    }
    
    if ($_SERVER['REQUEST_METHOD'] == 'POST') 
    {
        // Laad het database php script.
        $mysqli = '';
        require 'db.php';
        
        // Haal de email door een methode om MySql injections te voorkomen.
        $email = $mysqli->escape_string($_POST['email']);

        $resultaat = $mysqli->query("SELECT * FROM klanten WHERE email='$email'");
        
        // Wanneer de querie 1 of meerdere rows teruggeeft, dan bestaat het account.
        // Anders niet.
        if($resultaat->num_rows > 0 ){
            $gebruiker = $resultaat->fetch_assoc();
            
            // Hier gebruiken we een methode die het wachtwoord vergelijkt met de password hash die we in de database gemaakt hebben.
            if (password_verify($_POST['wachtwoord'], $gebruiker['wachtwoord']) ) {
                
                // Hier laden we (bijna) alle gegevens van de gebruiker zodat we deze op andere php paginas niet opnieuw hoeven te laden vanuit de database.
                $_SESSION['id'] = $gebruiker['id'];
                $_SESSION['email'] = $gebruiker['email'];
                $_SESSION['voornaam'] = $gebruiker['voornaam'];
                $_SESSION['achternaam'] = $gebruiker['achternaam'];
                $_SESSION['registratie'] = $gebruiker['registratie'];
                $_SESSION['actief'] = $gebruiker['actief'];
                $_SESSION['bestellingen'] = $gebruiker['bestellingen'];
                $_SESSION['spaarpunten'] = $gebruiker['spaarpunten'];
                $_SESSION['banned'] = $gebruiker['banned'];
        
                // Met deze variable laten we aan de rest van de php paginas zien dat de gebruiker zich daatwerkelijk heeft ingelogd.
                $_SESSION['ingelogt'] = true;
                
                // Verlaat deze pagina en laad de pagina profiel.php
                header("Location: profiel.php");
            } else{
                $error_msg = "Onjuist wachtwoord.<br>Probeer het opnieuw!";
            }
            
        } else{
            if(empty($resultaat)){
                $error_msg = "Oeps, er is iets verkeerd gegaan!";
            } else{
                $error_msg = "Er bestaat niet een account met die email.";
            }
        }
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- De titel van de website -->
    <title>DRL Pizza | Login</title>
    
    <!-- Charset -->
    <meta charset="utf-8">
    
    <link rel="stylesheet" href="..\theme.css">
    <link rel="stylesheet" href="..\animate.css">
    <link rel="stylesheet" href="forms.css">
    
    <!-- Deze paar regels zorgen voor de icons -->
    <link rel="icon" type="image/png" sizes="32x32" href="../resources/fav-icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="../resources/fav-icons/favicon-16x16.png">  
    
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
</head>
<body style="background-color: #95d895;">
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
            <div class="errorbox <?php if($error_msg == '') echo 'inactief'; ?>">
                <span><?php echo $error_msg;?></span>
            </div>
            
            <div class="loginform">
                <form action="login.php" method="post">
                    <h2>Login</h2>
                    
                    <h4>Email</h4>
                    <!-- Deze textbox heeft een PHP om de session email direct in te vullen. Vooral handig voor direct na de registratie. -->
                    <input type="email" required id="ftextbox" name="email" placeholder="Email..." value=" <?php if(!empty($_SESSION['email'])) echo $_SESSION['email']; ?>" >
                    <p></p>
                    <h4>Wachtwoord</h4>
                    <input type="password" required id="ftextbox" name="wachtwoord" placeholder="Wachtwoord...">
                    <br>
                    <br>
                    <button type="submit" id="fbutton" name="login"><span>Login</span></button>
                    <br>
                    <br>
                    <p style="width: 30em;text-align: center;"><a style="color: green; width: 30em;" href="register.php">Nog geen account? Klik hier om te registreren.</a></p>
                </form>
            </div>
        </div>
    </div>
</body>
</html>