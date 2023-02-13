var userData = {
  userName: "",
  phoneNumber: "",
  mobileNumer:"",
  Email:"",
  today: new Date().toLocaleDateString()
};
let userNameRegix=new RegExp("^[a-zA-Z]{1,10}$", "i");
let phoneNumberRegix =new RegExp("^[0-9]{8}$");
let mobileNumberRegix =new RegExp("^(010|011|012)[0-9]{8}$");
let emailRegix =/^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/;
do {
  userData.userName = prompt("enter your name", "Peter");
  if (!userNameRegix.test(userData.userName))
    alert("not valid input");
} while (!userNameRegix.test(userData.userName) );

do {
  userData.phoneNumber = prompt("enter your PhoneNumber", "24315368");
  if (!phoneNumberRegix.test(userData.phoneNumber))
    alert("not valid input");
} while (!phoneNumberRegix.test(userData.phoneNumber));

do {
    userData.mobileNumer = prompt("enter your PhoneNumber", "01206288674");
    if (!mobileNumberRegix.test(userData.mobileNumer))
      alert("not valid input");
  } while (!mobileNumberRegix.test(userData.mobileNumer));

  do {
    userData.Email = prompt("enter your PhoneNumber", "peterezzat97@gmail.com");
    if (!userData.Email.match(emailRegix))
      alert("not valid input");
  } while (!userData.Email.match(emailRegix));
  var color= prompt("enter your color", "red");
document.write("<p style=\"color:"+color+" ;\">user name: "+userData.userName+"</p> <br> <p style=\"color:"+color+" ;\">phonenumber: "+userData.phoneNumber+"</p> <br><p style=\"color:"+color+" ;\">mobile numer: "+userData.mobileNumer+"</p><br> <p style=\"color:"+color+" ;\">Email: "+userData.Email+"</p><br> <p style=\"color:"+color+" ;\">Today: "+userData.today+"</p>");