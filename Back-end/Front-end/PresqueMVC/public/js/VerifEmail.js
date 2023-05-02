// Fonction permettant de vérifier si l'adresse email est correcte
// La règle utilisée ici dans l'expression régulière est normée
// Paramètre : emailAVerifier chaine de caractères contenant l'adresse email à valider
// Sortie : la fonction renvoie vraie si l'adresse est correctre, faux sinon
function validationEmail(emailAVerifier) {
	var expressionReguliere = /^(([^<>()[]\.,;:s@]+(.[^<>()[]\.,;:s@]+)*)|(.+))@(([[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}.[0-9]{1,3}])|(([a-zA-Z-0-9]+.)+[a-zA-Z]{2,}))$/;
    return(expressionReguliere.test(emailAVerifier))
}