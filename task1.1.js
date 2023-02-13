var userInputStr = prompt("Please enter a string", "ay 7aga");
var counter = 0;
var userInputChar = prompt("enter any charachter from the string", "a");
if (confirm("Ignore letter cases")) {
  for (let i = 0; i < userInputStr.length; i++)
   userInputStr=userInputStr.toLowerCase();
}
for (let i = 0; i < userInputStr.length; i++) {
  if (userInputStr[i] === userInputChar) counter++;
}
confirm("number of apperance: " + counter);
