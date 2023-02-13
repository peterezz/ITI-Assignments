var userData=location.search;
// var searchValidation =  /^(\?name=)\.*(&address=)\w*(&gender=)\w*(&email=)\w*(&mobile=)\w*$/.test(userData);
// if(searchValidation){

    let userName = userData.slice(userData.indexOf("name=") +5,userData.indexOf("&address="));
    let userAddress = userData.slice(userData.indexOf("&address=") +9,userData.indexOf("&gender"));
    let userGender = userData.slice(userData.indexOf("&gender=") +8,userData.indexOf("&email"));
    let userMail = userData.slice(userData.indexOf("&email=") +7,userData.indexOf("&mobile"));
    let userMobile = userData.substring(userData.lastIndexOf("=")+1,userData.length-1);

    document.getElementById("wlcomeMessage").innerText = "Welcome " + userName;
    document.getElementById("name").innerText = userName;
    document.getElementById("address").innerText = userAddress;
    document.getElementById("gender").innerText = userGender;
    document.getElementById("email").innerText = userMail;
    document.getElementById("phone").innerText = userMobile;


//}