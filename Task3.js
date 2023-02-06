var input1 = 0,
  input2 = 0,
  range = 0;
input1 = +prompt("Please enter a number", "1");
do {
  input2 = +prompt("Please enter a number", "0");
} while (input1 == input2);
if (confirm("Display odd numbers")) {
  if (input1 < input2) {
    for (let i = input1; i <= input2; i++) {
      if (i % 2 == 1) {
        console.log(i);
      }
    }
  } else {
    for (let i = input1; i >= input2; i--) {
      if (i % 2 == 1) {
        console.log(i);
      }
    }
  }
} else {
  if (input1 > input2) {
    for (let i = input1; i >= input2; i--) {
      if (i % 2 == 0) {
        console.log(i);
      }
    }
  } else if(input1<input2) {
    for (let i = input2; i >= input1; i--) {
      if (i % 2 == 0) {
        console.log(i);
      }
      
    }
  }
}
