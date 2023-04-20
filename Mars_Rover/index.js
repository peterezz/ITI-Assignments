var rgx = /^(f|b|r|l)*$/i
var userInput;
do {
  userInput = prompt("enter dirctions: 'f','b','l','r'");
  if (!rgx.test(userInput) || userInput ==='') alert("invalid input");
} while (!rgx.test(userInput)||userInput ==='');
const initialCordinate={
    x:4,
    y:2,
    direction:'east'
};
var currnetCordinate={
    x:initialCordinate.x,
    y:initialCordinate.y,
    direction :initialCordinate.direction 
}
const directions =['east','south','west','north'];
var index=0;

function moveMarsRover(){
for(let i=0;i<userInput.length;i++){
    if("f"===userInput[i].toLowerCase())
    moveFarward();
    else if (userInput[i].toLowerCase() ==="b")
    moveBackward();
    else if (userInput[i].toLowerCase()==="l")
    rotateLeft();
    else if (userInput[i].toLowerCase()==="r")
    rotateRight();

}
alert(`current coordinate x: ${currnetCordinate.x} \n current coordinate y: ${currnetCordinate.y}\n direction: ${currnetCordinate.direction}`);
}
function moveFarward(){
  if(currnetCordinate.direction =='east')
        currnetCordinate.x++;
  else if(currnetCordinate.direction =='west')
        currnetCordinate.x--;
  else if(currnetCordinate.direction =='north')
        currnetCordinate.y++;
  else if (currnetCordinate.direction =='south')
        currnetCordinate.y--;
}
function moveBackward(){
    if(currnetCordinate.direction =='east')
    currnetCordinate.x--;
else if(currnetCordinate.direction =='west')
    currnetCordinate.x++;
else if(currnetCordinate.direction =='north')
    currnetCordinate.y--;
else if (currnetCordinate.direction =='south')
    currnetCordinate.y++;
}
function rotateRight(){
    if(index == directions.length-1)
        index = 0;
    else ++index;
currnetCordinate.direction = directions[index]

}

function rotateLeft(){
    if(index == 0)
        index = directions.length-1;
    else --index;
currnetCordinate.direction = directions[index]
}
moveMarsRover();
       