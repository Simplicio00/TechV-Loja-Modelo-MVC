$(document).ready(function () {
	GetMessagesHistory()
	RequestAddressJson()
	
	//ação de logoff
	$("#logoutbtn").click(function (e) {
		$.ajax({
			url: "/user/logout",
			success: function () {
				location.href = "https://localhost:5001"
			}
		})
	})

	$("#btnadvance").click(function(){
		document.getElementById("conteudopayment").style.display = "flex";
	})
	
})



async function RequestAddressJson() {
		
	var cep = document.getElementById("cepnumb").value;
	try {
		const uri = "https://localhost:5001/default/getaddress/" + cep
		const request = await fetch(uri)
		const response = await request.json()

		document.getElementById("endereco").innerText = response.cidade + ', ' + response.uf;
		document.getElementById("enderecobairro").innerText = response.bairro;
		document.getElementById("enderecoend").innerText = response.end;
		document.getElementById("enderecocomplemento").innerText = response.complemento;


	} catch (error) {
		console.log(error)
	}
}



async function GetMessagesHistory() {
	var id = document.getElementById("idchannel").value

	try {

		const uri = "https://localhost:5001/default/gethistory/" + id
		const request = await fetch(uri)

		var response = [];
		response = await request.json();

		response.forEach(msg => {
			var ml = document.getElementById("messageList");

			ml.textContent += " \n " + msg.nome + " : " + msg.mensagem 

		})


	} catch (e) {
		console.log(e);
	}

}