let imageArray=document.getElementsByTagName("img");
var CurrentImagePos=0;
const movinMarble={
    src:'/images/marble3.jpg',
    id:'currentPos'
}
const notMovingMarble={
    src:'/images/marble1.jpg',
    id:'nextPos'
}
function moveMarble(){
        if( CurrentImagePos>imageArray.length-1){
            imageArray[imageArray.length-1].src=notMovingMarble.src;
            imageArray[imageArray.length-1].id=notMovingMarble.id;
            CurrentImagePos =0;
            imageArray[CurrentImagePos].src=movinMarble.src;
            imageArray[CurrentImagePos].id=movinMarble.id;
        }else{
            imageArray[CurrentImagePos].src= notMovingMarble.src;
            imageArray[CurrentImagePos].id= notMovingMarble.id;   
            CurrentImagePos = CurrentImagePos+1;
            if(CurrentImagePos<=imageArray.length-1){
            imageArray[CurrentImagePos].src=movinMarble.src;
            imageArray[CurrentImagePos].id=movinMarble.id;;
            }
        }
    }
setInterval(moveMarble,1000);