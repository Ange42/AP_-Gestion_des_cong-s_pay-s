function validationInscription() {
	 
	// Récuparation de l'objet formulaire
	var formInsc  = document.getElementById('formInscription');
    
	// Ajout d'une écoute sur la fonction submit du formulaire
	// La fonction sera interrompue et la fonction de vérification sera jouée 
	formInsc.addEventListener("submit", function (event) {
		var inscriptionValide = true;

		// On efface les messages d'erreurs
		document.getElementById("form2AvatarNomError").className="";		
		document.getElementById("form2DifficulteError").className="";
		document.getElementById("form2CaracError").className="";
		document.getElementById("form2LoginError").className="";
		document.getElementById("form2MdpError").className = "";
		document.getElementById("form2AvatarNomError").innerHTML="";
		document.getElementById("form2DifficulteError").innerHTML="";		
		document.getElementById("form2CaracError").innerHTML="";
		document.getElementById("form2LoginError").innerHTML="";
		document.getElementById("form2MdpError").innerHTML = "";
        
		if (!inscriptionValide) {
			event.preventDefault();
		}
	}, false);
}