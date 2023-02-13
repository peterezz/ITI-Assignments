function autoScroll(){
setInterval(function(){
    console.warn("inside autoscroll");

    window.scrollBy(0,20);
}, 100);

}
autoScroll();