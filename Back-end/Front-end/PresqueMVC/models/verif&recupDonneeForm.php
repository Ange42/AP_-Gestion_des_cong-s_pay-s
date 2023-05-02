<?php
    // vérification des données du formulaire
    
    if(isset($_POST[':matricule']) && isset($_POST[':password']))
    // récupération des données du formulaire
    $matricule = htmlspecialchars($_POST['matricule']);
    $password = htmlspecialchars($_POST['password']);
    
     
?>