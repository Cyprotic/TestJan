<?php
header("Cache-Control: no-cache");
header('Access-Control-Allow-Origin: *');
header('Access-Control-Allow-Headers: Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With');
header('Content-Type: application/json');

$score = $_POST['score'];

//Connecting to database
$conn = new mysqli("localhost", "root", "", "jani");

$stmt = $conn->prepare("insert into dylani (score) values (?)");
$stmt->bind_param('i', $score);
$stmt->execute();
$conn -> close();
?>