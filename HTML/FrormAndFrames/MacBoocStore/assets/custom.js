window.onload = function() {

    var minPrice = document.getElementById('minprice');
    var maxPrice = document.getElementById('maxprice');
    var minRam = document.getElementById('minram');
    var maxRam = document.getElementById('maxram');
    var inputMinPrice = document.getElementById("minpricerange");
    var inputMaxPrice = document.getElementById("maxpricerange");
    var inputMinRam = document.getElementById("inputminram");
    var inputMaxRam = document.getElementById("inputmaxram");



    inputMinPrice.addEventListener("change", function() {
        minPrice.innerText = inputMinPrice.value;
    }, false);

    inputMaxPrice.addEventListener("change", function() {
        maxPrice.innerText = inputMaxPrice.value;
    }, false);
    inputMinRam.addEventListener("change", function() {
        minRam.innerText = inputMinRam.value;
    }, false);
    inputMaxRam.addEventListener("change", function() {
        maxRam.innerText = inputMaxRam.value;
    }, false);


};
