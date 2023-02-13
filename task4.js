var userInput;
do {
  userInput = +prompt(
    "what is the value of a circle radius?",
    "type radius here"
  );
} while (isNaN(userInput));
alert("total area of the circle is " + userInput * Math.PI * userInput);

do {
    userInput = +prompt(
      "what is the value you want to calculate its square root?",
      "type radius here"
    );
  } while (isNaN(userInput));
  alert("square root of "+userInput+" is " + Math.sqrt(userInput));

  do {
    userInput = +prompt(
      "what is the angle you want to calculate its cos value?",
      "type radius here"
    );
  } while (isNaN(userInput));
document.write("cos of "+userInput+" is " +Math.cos((userInput / 180) * Math.PI).toFixed());



