var paragraphe = document.getElementById("PAR");
onload = function() {
    paragraphe.style.fontFamily = "arial";
    paragraphe.style.textAlign = "left";
}
function ChangeFont(font){
    paragraphe.style.fontFamily = font;
    
}
function ChangeAlign(algin){
    paragraphe.style.textAlign = algin;
}
function ChangeHeight(hieght){
  

    paragraphe.style.lineHeight = hieght;
    
}
function ChangeLSpace(hieght){

    paragraphe.style.letterSpacing=hieght;
    
}
function ChangeIndent(indent){
    paragraphe.style.textIndent=indent;
}
function ChangeTransform(transform){
    paragraphe.style.textTransform = transform;
}
function ChangeColor(color){
    paragraphe.style.color = color;
}
function ChangeDecorate(decoration){
    paragraphe.style.textDecoration = decoration;
}
function ChangeBorder(border){
    paragraphe.style.border = border;
}
function ChangeBorderColor(color){
    paragraphe.style.borderColor = color;
}