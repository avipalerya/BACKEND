var scrooltoBenfit = function(){
    var elmntToView = document.getElementById("carouselExampleIndicators");
elmntToView.scrollIntoView(); 
}
var scrooltoUnsere = function () {
	var elmntToView = document.getElementById("Unsere");
	elmntToView.scrollIntoView();
}




var captcha;
function generate() {

	// Clear old input
	document.getElementById("submit").value = "";

	// Access the element to store
	// the generated captcha
	captcha = document.getElementById("image");
	var uniquechar = "";

	const randomchar =
		"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

	// Generate captcha for length of
	// 5 with random character
	for (let i = 1; i < 8; i++) {
		uniquechar += randomchar.charAt(
			Math.random() * randomchar.length)
	}

	// Store generated input
	captcha.innerHTML = uniquechar;
}

function printmsg() {
	const usr_input = document
		.getElementById("submit").value;

	// Check whether the input is equal
	// to generated captcha or not
	if (usr_input == captcha.innerHTML) {
		var s = document.getElementById("key")
			.innerHTML = "Matched";
		generate();
	}
	else {
		var s = document.getElementById("key")
			.innerHTML = "not Matched";
		generate();
	}
}



var loginUser = function () {
	var email = $("#lemail").val();
	//var email = document.getElementById("lemail").value(); 
	var passwrod = $("#password").val();
	if (email == "test123@gmail.com" && passwrod == "12345") {
		window.location.href = "/User/AboutMe"
	} else {
		alert("Login Faild");
    }
} 