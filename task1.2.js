var userInputStr=prompt("Please enter a string","moom");

var isPalindrome=true;

if(confirm("ignore case?"))
  userInputStr=userInputStr.toLowerCase();


for(let i =0;i<userInputStr.length/2;i++)
    isPalindrome=isPalindrome && (userInputStr[i]===userInputStr[userInputStr.length-i-1]); 

confirm("string is Palindrome: "+ isPalindrome);

