<?php
    /*  
    Rappel cyber : Dans une application, il est interdit d’utiliser des accès administrateurs (root). 
    il faut créer un compte ayant les droits suffisants et nécessaire sur la base de données.
    */
    
    // Connexion a la BDD
    try 
    {
        $bdd = new PDO ('mysql:host=localhost; dname=AP-2; charset=UTF=8; ', 'root', '');
        $bdd ->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION); 
    }
    catch (Exception $e)
    {
        die('Erreur de la connexion à la base de donnée : ' . $e->getMessage());
    }
 
?>