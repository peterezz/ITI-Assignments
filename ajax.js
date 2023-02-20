var artistList = document.getElementById("artist");
var output = document.getElementById("output");

document.getElementById("band").onchange = function () {
  artistList.innerHTML = "";
  displayartist(this.value);
};

/**request data server */
function displayartist(band) {
  var xhr = new XMLHttpRequest();
  xhr.open("GET", "../Data/rockbands.json");

  xhr.onreadystatechange = function () {
    if (xhr.readyState == 4) {
      if (xhr.status == 200) {
        data = JSON.parse(xhr.responseText)[band];
        console.log(data);
        for (var i = 0; i < data.length; i++) {
          var option = document.createElement("option");
          option.value = data[i].name;
          option.innerText += data[i].name;
          artistList.appendChild(option);
        }
        displaysignature(data[0].value);
      } else {
        console.log("failed");
      }
    }
  };
  xhr.send("");
}
artistList.onchange = function () {
  displaysignature(artistList.value);
};
function displaysignature(artist) {
  output.innerHTML = "";
  var signature = "";
  var txt = "";
  for (var i = 0; i < data.length; i++) {
    if (data[i].name === artist) signature = data[i].value;

    var pElem = this.document.createElement("a");

    if (signature.length == 0) txt = this.document.createTextNode(artist);
    else txt = this.document.createTextNode(signature);

    pElem.appendChild(txt);
    pElem.setAttribute("id", "id1");
    pElem.setAttribute("href", signature);
  }

  output.appendChild(pElem);
}
