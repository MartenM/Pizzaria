<?php
    session_start();

    // Error message die in het geval van een error gebruikt kan worden.
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
        // De methode is POST. De gebruiker verstuurt het formulier met verschillende variablen.
        
        // Creeër de database connectie in het db.php script.
        $mysqli = '';
        require 'db.php';
        
        // Hier halen we alle POST variablen door een filter om te zorgen dat kwade mensen geen MySql injections kunnen uitvoeren.
        $voornaam = $mysqli->escape_string($_POST['voornaam']);
        $achternaam = $mysqli->escape_string($_POST['achternaam']);
        $email = $mysqli->escape_string($_POST['email']);

        // Het zelfde gebeurt met het wachtwoord. Deze geëncrypt door een HASH.
        $wachtwoord = $mysqli->escape_string(password_hash($_POST['wachtwoord'], PASSWORD_BCRYPT));
        // Dit is een random hash die kan worden gebruikt voor email verificatie.
        $hash = $mysqli->escape_string( md5( rand(0,1000) ) );
        
        // Deze querie kijkt of de email niet al bestaat in de database.
        $resultaat = $mysqli->query("SELECT * FROM klanten WHERE email='$email'") or die($mysqli->error);
        
        // Als het resultaat rows bezit dan bestaat de email dus al.
        if ( $result->num_rows > 0 ) {
            $error_msg = "Er is al een email met deze naam!";
        } else if(checkVariablen() != ''){
            $error_msg = checkVariablen();
        }
        else{
            // Email bestaat nog niet. Start echte registratie.
            $sql = "INSERT INTO klanten (voornaam, achternaam, email, wachtwoord, hash) " 
            . "VALUES ('$voornaam','$achternaam','$email','$wachtwoord', '$hash')";
            
            // Deze if statement retourneert true wanneer de querie succesvol is afgerond.
            // Anders false.
            if ( $mysqli->query($sql) ){
                
                // Gebruiker heeft zich succesvol geregisteerd!
                // Creeër de sessie gegevens voor deze gebruiker om in te loggen.
                
                $_SESSION['email'] = $email;
                $_SESSION['voornaam'] = $voornaam;
                $_SESSION['achternaam'] = $achternaam;
                
                // Ga naar de login pagina:
                header("Location: login.php");
                
            } else{
                $error_msg = "Registratie is mislukt door een onbekende fout!<br>Probeer het later opnieuw.";
            }
        }
        
    }

    function checkVariablen(){
        $error = '';
        if(strlen($_POST['voornaam']) < 3){
            $error .= "Voornaam moet minimaal 3 tekens lang zijn.<br>";
        }
        if(strlen($_POST['achternaam']) < 3){
            $error .= "Achternaam moet minimaal 3 tekens lang zijn.<br>";
        }
        if(strlen($_POST['wachtwoord']) < 6){
            $error .= "Wachtwoord moet minimaal 6 tekens lang zijn.<br>";
        }
        return $error;
    }
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- De titel van de website -->
    <title>DRL Pizza | Registratie</title>
    
    <!-- Charset -->
    <meta charset="utf-8">
    
    <link rel="stylesheet" href="../theme.css">
    <link rel="stylesheet" href="../animate.css">
    <link rel="stylesheet" href="forms.css">
    
    <!-- Deze paar regels zorgen voor de icons -->
    <link rel="icon" type="image/png" sizes="32x32" href="../resources/fav-icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="../resources/fav-icons/favicon-16x16.png">  
    
    <!-- Latest compiled and minified CSS van boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme voor boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript voor boostrap -->
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
                <form action="register.php" method="post">
                    <!-- Dit is een redelijk normaal PHP form dat wanneer het form verstuurd word opgestuurd zal worden in de POST methode.
                         Om er voor te zorgen dat de values hetzelfde blijven bij een error zit er ook wat PHP code in verwerkt dat de values naar de corrosponderende POST values zet. -->
                    
                    <h2 id="header">Registreer</h2>
                    
                    <h4>Voornaam</h4>
                    <input type="text" required id="ftextbox" name="voornaam" placeholder="Voornaam..." value="<?php if(!empty($_SESSION['voornaam'])) echo $_SESSION['voornaam']; ?>">
                    <br>
                    <h4>Achternaam</h4>
                    <input type="text" required id="ftextbox" name="achternaam" placeholder="Achternaam..." value="<?php if(!empty($_SESSION['achternaam'])) echo $_SESSION['achternaam']; ?>">
                    <br>
                    <h4>Email</h4>
                    <input type="email" required id="ftextbox" name="email" placeholder="Email..." value="<?php if(!empty($_SESSION['email'])) echo $_SESSION['email']; ?>">
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