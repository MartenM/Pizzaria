<?php
/*Hiermee stoppen we de error notices die op de pagina verschijnen.*/
error_reporting( error_reporting() & ~E_NOTICE );

/* Alle gegevens nodig voor de connectie met de database */
$adress = 'localhost';
$username = 'root';
$password = 'root';
$database = 'pizzaria';

/* Maak een connectie en open deze. Bij een error stop het php script. */
$mysqli = new mysqli($host,$user,$pass,$db) or die($mysqli->error);
?>