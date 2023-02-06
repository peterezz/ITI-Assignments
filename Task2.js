var number1=0,Input1=1;

while(number1<100 && Input1 != 0){
    Input1 = parseInt(prompt("Please enter a number", "1"));
    number1 += Input1;
}

alert(number1)