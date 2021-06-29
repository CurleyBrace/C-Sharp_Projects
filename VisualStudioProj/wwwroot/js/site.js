//Retrieving Objects from DOM
var modal = document.getElementById("modalCont");
var img = document.getElementById("imgCont");
var modalImg = document.getElementById("pupImg");
var captionTxt = document.getElementById("caption");

//On click Function to Open Modal
img.onclick = function () {
    modal.style.display = "block";
    modalImg.src = this.src;
    captionTxt.innerHTML = this.alt;
}

var span = document.getElementsByClassName("close")[0];

//On click Function to Close Modal
span.onclick = function () {
    modal.style.display = "none";
}
