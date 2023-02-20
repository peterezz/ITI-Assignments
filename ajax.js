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
        var option = document.createElement("option");
        option.innerText = "Please select an artist";
        option.setAttribute("selected", "selected");
        option.setAttribute("disabled","disabled");
        artistList.appendChild(option);  
        for (var i = 0; i < data.length; i++) {
          var option = document.createElement("option");
          option.value = data[i].name;
          option.innerText = data[i].name;
          artistList.appendChild(option);
        }
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
  for (var i = 0; i < data.length; i++)
    if (data[i].name === artist) signature = data[i].value;
  if (signature.length == 0) signature = artist;
  window.open(signature, "_blank");
}
