const genderImg = {
  male: "/images/1.jpg",
  female: "/images/2.jpg",
};
var cookieArr = [];

if (document.forms.length > 0) {
  document.forms[0].onsubmit = function () {
    let username = document.getElementById("username");
    let age = document.getElementById("age");
    let gender = document.querySelector('input[name="gender"]:checked');
    let list = document.getElementById("list");

    var date = new Date();
    date.setMonth(date.getMonth() + 1);
    var profilePic = gender.value === "male" ? genderImg.male : genderImg.female;

    setCookie(username.name, username.value, date);
    setCookie(age.name, age.value, date);
    setCookie(gender.name, profilePic, date);
    setCookie(list.name, list.value, date);
    setCookie("visitNum", "0", date);
  };
}
function setCookie(name, value, expires) {
  document.cookie = name + "=" + value + ";expires=" + expires.toUTCString();
}
function getCookie(name) {
    return cookieArr[name];
}
function getAllCookies(){
    var data = document.cookie.split('; ')

 
    for(var counter = 0;counter<data.length;counter++){
        var key = data[counter].split('=')//[key,value]
        cookieArr[key[0]] = key[1]
    }

}
function deleteCookie(name) {
    var date = new Date();
    date.setMonth(date.getMonth() - 1);
  document.cookie = name + '=;expires='+date.toUTCString();
}
  function clearAllCookies() {
    document.cookie = '';
  }