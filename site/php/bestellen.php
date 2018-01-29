<?php
    // Start sessie zodat we bij de gebruikers gegevens kunnen.
    session_start();
    
    // Check of de gebruiker ingelogt is. Zo niet dan stop de php code hier en word de gebruiker doorgestuurd.
    require 'checklogin.php';

    // Haal de database connectie op.
    $mysqli = '';
    require "db.php";
    
    
    $sql = "SELECT * FROM pizzas;";
    $pizzas = $mysqli->query($sql);
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
            
            <div class="bestellen">
                <div>
                    <h2>Stel uw bestelling samen,</h2>
                    <h4>en klik dan op bestel.</h4>            
                </div>
                
                <div class="bestelvenster">
                    <form action="bestellen.php" method="post">
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
                                        echo "<td style='text-align: center;'>" . "Aantal: <input class='numeric' type='number' value='0'></td>";
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