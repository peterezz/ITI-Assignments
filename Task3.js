let userInput = [];
for (let i = 0; i < 5; i++) {
  do {
    userInput[i] = +prompt("Enter a number between 1 and 10");
  } while (isNaN(userInput[i]) || userInput[i] < 1 || userInput[i] > 10);
}
document.writeln("<h1>Sorting</h1>");
document.write("you entered: ");

function displayArray(array) {
  for (let i = 0; i < array.length; i++) {
    if (i == array.length - 1) document.write(array[i]);
    else document.write(array[i] + ", ");
  }
}

function SortArray(arr, typeOfSort = "desc") {
  if (typeOfSort == "desc") {
    arr.sort((a, b) => b - a); // For descending sort
  } else if (typeOfSort == "asc") {
    arr.sort((a, b) => a - b); // For ascending sort
  }

  return arr;
}

displayArray(userInput);
document.write("<br> sort array desc:");
displayArray(SortArray(userInput, "desc"));
document.write("<br>sort array asc: ");
displayArray(SortArray(userInput, "asc"));
