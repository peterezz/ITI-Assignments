var userInputStr=prompt("Please enter a string","moom");
getLargestString();


function getLargestString(){
    var arrOfStrings = userInputStr.split(" ");
    console.log(arrOfStrings);
    var longestString="";
    for(let i=0;i<arrOfStrings.length;i++)
    {
        if(arrOfStrings[i].length > longestString.length)
            longestString=arrOfStrings[i];
    
    }
    alert("longest string is "+longestString);
}
