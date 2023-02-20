const box = document.querySelector(".box");
const output = document.querySelector(".output");
var btnGo = document.getElementById("BtnGo");

var resultOutput = {
  output1: document.getElementById("output1"),
  output2: document.getElementById("output2"),
  output3: document.getElementById("output3"),
};
const Pics = {
  frasha: document.querySelector(".frasha"),
  sahm: document.querySelector(".sahm"),
  wrda: document.querySelector(".wrda"),
};
const picSize = 50;
const picsCoordinates = {
  frashaCoordinate: parseInt(
    window.getComputedStyle(Pics.frasha).getPropertyValue("left")
  ),
  sahmCoordinate: parseInt(
    window.getComputedStyle(Pics.sahm).getPropertyValue("top")
  ),
  wrdaCoordinate: parseInt(
    window.getComputedStyle(Pics.wrda).getPropertyValue("left")
  ),
};

var boxBoundaries = {
  topBoundary: 50,
  bottomBoundary: parseInt(window.getComputedStyle(box).height) - picSize,
  leftBoundary: 50,
  rightBoundary:
    parseInt(window.getComputedStyle(document.querySelector(".box")).width) -
    100,
};

btnGo.onclick = sartMoving;
Pics.sahm.style.top = picsCoordinates.sahmCoordinate + "px";
Pics.frasha.style.left = picsCoordinates.frashaCoordinate + "px";
Pics.wrda.style.left = picsCoordinates.wrdaCoordinate + "px";
function sartMoving() {

  interval = setInterval(function () {
    movingCoordinates = {
      sahmNewCoordinate: parseInt(Pics.sahm.style.top),
      frashaNewCoordinate: parseInt(Pics.frasha.style.left),
      wrdaNewCoordinate: parseInt(Pics.wrda.style.left),
    };
    if (movingCoordinates.sahmNewCoordinate > boxBoundaries.topBoundary)
      movingCoordinates.sahmNewCoordinate =
        parseInt(Pics.sahm.style.top) - picSize + "px";
    else
      movingCoordinates.sahmNewCoordinate =
        picsCoordinates.sahmCoordinate + "px";
    Pics.sahm.style.top = movingCoordinates.sahmNewCoordinate;
    resultOutput.output1.innerText =
      '<img src="images/TOP.JPG" alt="frasha" class="frasha" style="top:' +
      movingCoordinates.sahmNewCoordinate +
      '">';

    if (movingCoordinates.frashaNewCoordinate > boxBoundaries.leftBoundary)
      movingCoordinates.frashaNewCoordinate =
        parseInt(Pics.frasha.style.left) - picSize + "px";
    else
      movingCoordinates.frashaNewCoordinate =
        picsCoordinates.frashaCoordinate + "px";
    Pics.frasha.style.left = movingCoordinates.frashaNewCoordinate;
    resultOutput.output2.innerText =
      '<img src="images/icon1.gif" alt="frasha" class="frasha" style="left:' +
      movingCoordinates.frashaNewCoordinate +
      '">';

    if (movingCoordinates.wrdaNewCoordinate < boxBoundaries.rightBoundary)
      movingCoordinates.wrdaNewCoordinate =
        parseInt(Pics.wrda.style.left) + picSize + "px";
    else
      movingCoordinates.wrdaNewCoordinate =
        picsCoordinates.wrdaCoordinate + "px";
    Pics.wrda.style.left = movingCoordinates.wrdaNewCoordinate;
    resultOutput.output3.innerText =
      '<img src="images/icon2.gif" alt="frasha" class="frasha" style="left:' +
      movingCoordinates.wrdaNewCoordinate +
      '">';
  }, 500);
}
document.getElementById("BtnReset").onclick = resetMoving;

function resetMoving() {
  Pics.sahm.style.removeProperty("top");
  Pics.frasha.style.removeProperty("left");
  Pics.wrda.style.removeProperty("left");
  resultOutput.output1.innerText = "";
  resultOutput.output2.innerText = "";
  resultOutput.output3.innerText = "";
  var interval_id = window.setInterval(() => {}, 99999);
  for (var i = 0; i < interval_id; i++) window.clearInterval(i);
}
document.getElementById("btnStop").onclick = stopMoving;
function stopMoving() {
  var interval_id = window.setInterval(() => {}, 99999);
  for (var i = 0; i < interval_id; i++) window.clearInterval(i);
}
