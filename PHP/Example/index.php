<?php
session_start();
include 'dashboard.php';
include 'login.php';
echo "Hello world!";
$varName = "Hello bro!";

echo $varName;
$username = $_GET['username'];
$password = $_GET['password'];

if (isset($_GET['username'])) {
    $username = $_GET['username'];
    $password = $_GET['password'];
    echo $username;
    echo $password;
}
