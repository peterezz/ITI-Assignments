let massege="typing massege...";
let massegeLength=massege.length;
let massegeCurrentIteration=0;
function displayLetters(){
    var timer=setInterval(function(){
         document.getElementById("massege").innerHTML += massege[massegeCurrentIteration++];
         if(massegeCurrentIteration>massegeLength-1)
            clearInterval(timer);
        
},50)
setTimeout(function(){
    window.close();

  },1000)
}
displayLetters();
