let imageArray=["img1.jpg","img2.jpg","img3.jpg","img4.jpg","img5.jpg"];
let currentImage=document.getElementById('currentImage').src.split('/')[4];
let currentImageIndex =imageArray.indexOf(currentImage);


document.getElementById('btnNext').onclick =normalSlideShow;
document.getElementById('btnPrevious').onclick = oppositeSlideShow;
document.getElementById('btnStop').onclick = stopSlideShow;


function oppositeSlideShow(){
     currentImageIndex=currentImageIndex-1;
    if(currentImageIndex>=0)
    document.getElementById('currentImage').src="/images/"+imageArray[currentImageIndex];
}


function normalSlideShow(){
     currentImageIndex=currentImageIndex+1;
    if(currentImageIndex<imageArray.length)
    document.getElementById('currentImage').src="/images/"+imageArray[currentImageIndex];  
}

document.getElementById('btnSlideShow').onclick = function () {
    interval=setInterval(function(){
        if(currentImageIndex==imageArray.length-1)
        oppositeSlideShow();
        else
        normalSlideShow();
    },500)
}

function stopSlideShow(){
    clearInterval(interval);
}