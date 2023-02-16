const marbleSrc={
    light:'/images/marble3.jpg',
    dark:'/images/marble1.jpg',
    gray:'/images/marble2.jpg',


}
let centerMarble=document.querySelector('.centerBall')

var outBalls = document.querySelectorAll('.outBall');
for (var i = 0; i < outBalls.length; i++) {
    outBalls[i].onmouseover = function () {
        for (var j = 0; j < outBalls.length; j++) {
            outBalls[j].src=marbleSrc.light;
        }
        centerMarble.src=marbleSrc.gray;
        
        
    }
}
for (var i = 0; i < outBalls.length; i++) {
    outBalls[i].onmouseout = function () {
        for (var j = 0; j < outBalls.length; j++) {
            outBalls[j].src=marbleSrc.dark;
        }
        centerMarble.src=marbleSrc.light;
        
        
    }
}