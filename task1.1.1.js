//var windowPoundries = window.
var child, timer;
let flyingWindowCordinates = {
  X: 0,
  Y: 0,
};
const screenBoudry = {
  X: 850,
  Y: 553,
};
let flyingStep = {
  X: 100,
  Y: 100,
};

function openFlyingWindow() {
  child = window.open("child.html", "top", "width=500px,height=100px");
}
function moveFlyingWindow() {
  timer = setInterval(function () {
    flyingWindowCordinates.X = child.screenX;
    flyingWindowCordinates.Y = child.screenY;

    if (flyingWindowCordinates.X >= screenBoudry.X)
      flyingStep.X = -flyingStep.X;
      else     if (flyingWindowCordinates.Y >= screenBoudry.Y)
      flyingStep.Y = -flyingStep.Y;
      else     if (flyingWindowCordinates.X == 0)
      flyingStep.X = flyingStep.X+200;
      else     if (flyingWindowCordinates.Y == 0)
      flyingStep.Y = flyingStep.Y+200;
    child.moveBy(flyingStep.X, flyingStep.Y);
    child.focus();
    console.log(
      "x: " + flyingWindowCordinates.X + " y: " + flyingWindowCordinates.Y
    );
  }, 1000);
}
function closeFlyingWindow() {
  child.close();
  clearInterval(timer);
}
function OpenAppearingMassegeWindow() {
  window.open("massege.html", "_blank", "width=500px,height=100px");
}
