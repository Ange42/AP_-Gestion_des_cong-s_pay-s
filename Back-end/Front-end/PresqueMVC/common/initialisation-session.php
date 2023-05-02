<?php
    session_start();
    $id_session = session_id();
    if ($id_session)
    {
        echo $id_session; // ID de session récupéré grace au session_id
    }

    echo '<br><br>';
    if (isset($_COOKIE['PHPSESSID']))
    {
       // echo $_COOKIE; // ID de session récupéré via $_COOKIE 
    }
?>