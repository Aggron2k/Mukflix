<?php
    function dbkapcs()
    {
        $host="localhost";
        $user="root";
        $pass="";
        $db="mukflix";
        global $kapcs;

    $kapcs=mysqli_connect($host,$user,$pass,$db) or die("Hiba kapcsolódáskor!");
    $kapcs -> set_charset("utf8");
    return $kapcs;

    }
?>
