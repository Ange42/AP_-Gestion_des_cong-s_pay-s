<?php

    // préparation de la requête d'inserttion
    $req = $bdd -> prepare('INSERT INTO personnage (nom, prenom) VALUES (:nom, :classe)');
    $req->bindValue (':nom', $nom, PDO::PARAM_STR);
    $req->bindValue (':prenom', $prenom, PDO::PARAM_STR);

    // éxécution de la requête
    $req->execute();

?>