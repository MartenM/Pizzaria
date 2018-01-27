<?php
    session_start();

    $error_msg = '';

    $notify_msg = '';


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <!-- De titel van de website -->
    <title>DRL Pizza | Profiel</title>

    <!-- Charset -->
    <meta charset="utf-8">

    <link rel="stylesheet" href="..\theme.css">
    <link rel="stylesheet" href="..\animate.css">
    <link rel="stylesheet" href="profielpagina.css">

    <!-- Import van de Roboto font -->
    <link href="https://fonts.googleapis.com/css?family=Roboto" rel="stylesheet">

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

            <div class="msg_box">

            </div>

            <div class="profiel">
                <div class="naam">
                    <h2>Welkom terug,</h2>
                    <h4><?php echo $_SESSION['voornaam'] . ' ' . $_SESSION['achternaam'] ?></h4>
                </div>

                <div class="stats">
                    <ul>
                        <li><img src="https://cdn4.iconfinder.com/data/icons/pictograms-1/512/Calendar-512.png" style="height: 16px; width: 16px"> <span class="key">Geregistreerd op:</span> <span class="value"><?php echo $_SESSION['registratie'];?></span></li>
                        <li><img src="https://services.garmin.com/appsLibraryBusinessServices_v0/rest/apps/da79ef76-eb92-48ba-a360-dd4dd1519b03/icon/30162724-ed8b-4a46-93ca-37c4d4ab8d45" style="height: 16px; width: 16px"> <span class="key">Aantal bestellingen:</span> <span class="value"><?php echo $_SESSION['bestellingen'];?></span></li>
                        <li><img src="http://www.iconarchive.com/download/i99744/sonya/swarm/Pizza.ico" style="height: 16px; width: 16px"> <span class="key">Spaarpunten:</span> <span class="value"><?php echo $_SESSION['spaarpunten'];?></span></li>
                    </ul>
                </div>

                <div class="geschiedenis">

                </div>

            </div>
        </div>
    </div>
</body>
</html>
