// On vérifie qu'un nom a été saisi
if (document.getElementById("form2AvatarNom").value=="")
{
    errorHTML="Vous devez choisir un nom pour votre avatar !";
    document.getElementById("form2AvatarNomError").innerHTML = errorHTML	
    document.getElementById("form2AvatarNomError").className="formErrorMsg";
    inscriptionValide=false;
}

// On vérifie qu'un genre a été sélectionné
if (document.getElementById("form2Difficulte").value=="0")
{
    errorHTML="Vous devez sélectionner un genre !";
    document.getElementById("form2DifficulteError").innerHTML = errorHTML	
    document.getElementById("form2DifficulteError").className="formErrorMsg";
    inscriptionValide=false;
}

// On vérifie l'adresse email avec la fonction validationEmail
if (!validationEmail(document.getElementById("form1Login").value))
{
    errorHTML=" L'adresse email n'est pas valide !";
    document.getElementById("form1LoginError").innerHTML = errorHTML
    document.getElementById("form1LoginError").className="formErrorMsg";
    inscriptionValide=false;
}

// Vérification saisi du mot de passe 
if (document.getElementById("form1Mdp").value=="" )
{
    errorHTML="Vous devez saisir un mot de passe !";
    document.getElementById("form1MdpError").innerHTML = errorHTML
    document.getElementById("form1MdpError").className="formErrorMsg";
    inscriptionValide=false;
}   

// Vérification de la conformité du mot de passe 
var mdp = document.getElementById("form2Mdp").value; 
if (!mdp.match( /[0-9]/g) ||                // Il y a un chiffre
        !mdp.match( /[A-Z]/g) ||            // Il y a une majuscule
        !mdp.match(/[a-z]/g) ||             // il y a une minuscule 
        !mdp.match( /[^a-zA-Z\d]/g))        // il y a un caractère spécial
{
    errorHTML=" Le mot de passe doit contenir :<br> Une majuscule, une minuscule, un chiffre, un caractère spécial!";
    document.getElementById("form2MdpError").innerHTML = errorHTML
    document.getElementById("form2MdpError").className="formErrorMsg";
    inscriptionValide=false;
}