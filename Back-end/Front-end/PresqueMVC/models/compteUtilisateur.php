
        <?php
         
        /*
        Rappel cyber : Dans une application, il est interdit d’utiliser des accès administrateurs (root).
        Il faut créer un compte ayant les droits suffisants et nécessaire sur la base de données.
        */

		//Informations nécessaires à la connexion
            $servername = 'localhost';
		    $dbname='AP-2';
            $username = 'root';
            $password = '';
            
            //On établit la connexion
           $conn = new PDO("mysql:host=$servername;dbname=$dbname", $username, $password);
        ?>
    </body>
</html>

 
