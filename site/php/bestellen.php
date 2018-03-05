<?php
    // Start sessie zodat we bij de gebruikers gegevens kunnen.
    session_start();

    // Variable die wordt gebruikt wanneer er een error is.
    $error_msg = '';
    
    // Check of de gebruiker ingelogt is. Zo niet dan stop de php code hier en word de gebruiker doorgestuurd.
    require 'checklogin.php';

    require 'pizzaObject.php';

    // Haal de database connectie op.
    $mysqli = '';
    require "db.php";
    
    $sql = "SELECT * FROM pizzas;";
    $pizzas = $mysqli->query($sql);

    if ($_SERVER['REQUEST_METHOD'] == 'POST') 
    {
        // POST dus de gebruiker probeert te bestellen!
        $totaalprijs = 0.00;
        $bestelling = '';
        $error = false;
        $korting = 0.00;
        
        $lijst = array();
        
        while($rij = $pizzas->fetch_assoc()) {
            
            $aantal = $_POST[$rij['naam']];
            
            if(!empty($aantal)){
                if(!is_numeric($aantal)){
                    $error = true;
                    $error_msg = "Ongeldige waarde voor aantal pizzas: " . $rij['naam'];
                    break;
                } else{
                    if(intval($aantal) < 0){
                        $error = true;
                        $error_msg = "Ongeldige waarde voor aantal pizzas: " . $rij['naam'];
                        break;
                    }
                    
                    if(intval($aantal) > intval($rij['voorraad'])){
                        $error = true;
                        $error_msg = "Er zijn nog maar " . $rij['voorraad'] . " van de " . $rij['naam'] . " pizza's op vooraad! Geliefd uw aantal naar beneden af te stellen.";
                        break;
                    }
                    
                    $totaalprijs = $rij['prijs'] * intval($aantal);
                    $bestelling = $bestelling . $aantal . " " . $rij['naam'] . " ";
                
                    // Maak een pizza object en zet deze in de array.
                    // Op deze manier kunnen we snel de bestelling doorgeven naar ander paginas.
                    $object = new PizzaObject();
                    $object->setVariablen($rij['naam'], $rij['prijs'], $aantal);
                    
                    array_push($lijst, $object);
                }
            }
        }
		
		if($bestelling = '' || count($lijst) == 0){
			$error = true;
            $error_msg = "Ongeldige bestelling.";
		}
        
        if(!$error){
            $adres = 'N.V.T.';
            $afhalen = false;
            if($_POST['bezorgen'] == "Nee"){
                // Gebruiker gaat de pizzas afhalen vanaf het filiaal.
                // Korting van 5% toerekenen!
                // Korting afronden op 2 decimalen.
                $korting = round(($totaalprijs * 0.05), 2);
                $totaalprijs = $totaalprijs - $korting;
            } else {
                $afhalen = true;
                $adres = $_POST['straat'] . " " . $_POST['huisnummer'] . " " . $_POST['plaats'];
            }
            
            $_SESSION['msg_succes'] = "De bestelling is succesvol afgerond!<br><br>";
            
            foreach($lijst as $object){            
                $_SESSION['msg_succes'] = $_SESSION['msg_succes'] . " > " . $object->naam . " €" .  ($object->prijs * $object->aantal) . "<br>";
            }
            
            $_SESSION['msg_succes'] = $_SESSION['msg_succes'] . "<br>Korting: €" . $korting . "<br>";
            $_SESSION['msg_succes'] = $_SESSION['msg_succes'] . "=============================";
            $_SESSION['msg_succes'] = $_SESSION['msg_succes'] . "<br>Totaal: €" . $totaalprijs;
            
            // Gereed maken voor insert:
            $bestelling = $mysqli->escape_string($bestelling);
            
            // Update de databases:
            $sql_bestelling = "INSERT INTO bestellingen (klant, bestelling, afhalen, adres, totaalprijs) " 
            . "VALUES (" . $_SESSION['id'] . ",'$bestelling','$afhalen','$adres', '$totaalprijs');";
            
            // Deze if statement retourneert true wanneer de querie succesvol is afgerond.
            // Anders false.
            if ($mysqli->query($sql_bestelling) ){
                // Query heeft gewerkt. Schrijf de vooraad af.
                foreach($lijst as $object){            
                    $sql_pizzavooraad = "UPDATE pizzas SET voorraad= voorraad - " . $object->aantal . " where naam='$object->naam';";
                    $mysqli->query($sql_pizzavooraad);
                }
            
            } else {
                $_SESSION['msg_notice'] = "Er is iets mis gegaan tijdens het bestellen. Geliefd het nog een keer te proberen.<br><br>" . $mysqli->error . "<br><br>" . $sql_bestelling;
            }
            
            header("Location: profiel.php");   
            exit;
            
        } else{
            // Wanneer er een error is komt de gebruiker terug op deze pagina.
            // In dat geval laden we de database nog een keer.
            $pizzas = $mysqli->query($sql);
        }
    }
    
    
    
?>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- De titel van de website -->
    <title>DRL Pizza | Bestelling voor <?php echo $_SESSION['voornaam']; ?></title>

    <!-- Charset -->
    <meta charset="utf-8">

    <link rel="stylesheet" href="..\theme.css">
    <link rel="stylesheet" href="..\animate.css">
    <link rel="stylesheet" href="bestelpagina.css">

    <!-- Import van de Roboto font -->
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">
    
    <!-- Deze paar regels zorgen voor de fav icons -->
    <link rel="icon" type="image/png" sizes="32x32" href="../resources/fav-icons/favicon-32x32.png">
    <link rel="icon" type="image/png" sizes="16x16" href="../resources/fav-icons/favicon-16x16.png">

    <!-- Latest compiled and minified CSS van boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.min.css" integrity="sha384-BVYiiSIFeK1dGmJRAkycuHAHRg32OmUcww7on3RYdg4Va+PmSTsz/K68vbdEjh4u" crossorigin="anonymous">

    <!-- Optional theme voor boostrap -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap-theme.min.css" integrity="sha384-rHyoN1iRsVXV4nD0JutlnGaslCJuC7uwjduW9SVrLvRYooPp2bWYgmgJQIXwl/Sp" crossorigin="anonymous">

    <!-- Latest compiled and minified JavaScript voor boostrap -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/js/bootstrap.min.js" integrity="sha384-Tc5IQib027qvyjSMfHjOMaLkfuWVxZxUPnCJA7l2mCWNIpG9mGCD8wGNIcPD7Txa" crossorigin="anonymous"></script>
    
    <script>
        var old = false;
        function updateBezorgen(status){
            if(status == old) return;
            old = status;
            
            if(status){
                document.getElementById("adresinfo").className = "adres animated fadeIn";
            } else {
                document.getElementById("adresinfo").className = "adres animated fadeOut";
                setTimeout(function() {
                    document.getElementById("adresinfo").className = "adres hide";}
                            , 800);
            }
        }  
    </script>
    
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
                    <li><a href="uitloggen.php">Uitloggen</a></li>
                </ul>
            </div>
        </div>
    </nav>
    
    <div class="venster">
        <div class="container">
            <div class='error-box <?php if($error_msg == '') echo hide;?>'>
                <span><?php echo $error_msg;?></span>
            </div>
            
            
            <div class="bestellen">
                <div>
                    <h2>Stel uw bestelling samen,</h2>
                    <h4>en klik dan op bestel.</h4>            
                </div>
                
                <div class="bestelvenster">
                    <form action="bestellen.php" method="post">
                        
                        <div class="opties clearfix">
                            <div class="links"> 
                                <h3>Wilt u de pizza laten bezorgen?</h3>
                                <div class="radiobuttons">
                                    <input type="radio" onclick="updateBezorgen(false)" name="bezorgen" value="Nee" checked> Nee
                                    <input type="radio" onclick="updateBezorgen(true)" name="bezorgen" value="Ja"> Ja
                                </div>
                                
                                <div class="adres hide" id="adresinfo">
                                    <p>Plaats:</p>
                                    <input class="knop" type="text" name="plaats" placeholder="Plaats"><br>
                                    <p>Straat:</p>
                                    <input class="knop" type="text" name="straat" placeholder="Straat"><br>
                                    <p>Huisnummer:</p>
                                    <input type="text" name="huisnummer" placeholder="Huisnummer"><br>
                                </div>
                            </div>
                            
                            <div class="rechts">
                                <button type="submit" id="fbutton">
                                    <img style="height: 16px; width: 16px" src="http://wfarm2.dataknet.com/static/resources/icons/set112/54979173.png"> Plaats bestelling!
                                </button>
                            </div>
                        </div>
                        
                        <table>
                            <tr>
                                <th>Pizza naam</th>
                                <th>Beschrijving</th>
                                <th>Prijs</th>
                                <th></th>
                                <th></th>
                            </tr>
                            
                            <?php 
                                while($rij = $pizzas->fetch_assoc()) {
                                    echo "<tr>";
                                        
                                    echo "<td>" . $rij['naam'] . "</td>";
                                    echo "<td>" . $rij['beschrijving'] . "</td>";
                                    echo "<td>" . $rij['prijs'] . "</td>";
                                    echo "<td>" . "<img style='height: 6vw; width: 6vw;' src='" . $rij['img'] . "'></td>";
                                        
                                    if($rij['voorraad'] > 0){
                                        echo "<td style='text-align: center;'>" . "Aantal: <input class='numeric' type='number' value='0' name='" . $rij['naam'] . "'></td>";
                                    } else{
                                        echo "<td>" . "<img style='height: 3vw; width: 6vw;' src=../resources/img/uitverkocht.png>" . "</td>";
                                    }
                                        
                                        
                                        
                                    echo "</tr>";
                                    }
                                ?>
                        </table>
                    </form>
                </div>
                
            </div>
        </div>
    </div>
</body>
</html>