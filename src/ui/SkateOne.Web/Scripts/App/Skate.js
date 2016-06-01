var skate = new Vue({
    el: '#skate',
    data: {
        message: 'Hello Vue.js!'
    }
});

var target1PosX = "650px";
var target2PosX = "10px";

var logoTargetPosX = target1PosX;

function canvasClick() {
    var canvasInit = document.getElementById("canvasInit");
    TweenLite.to(canvasInit, 1, { left: logoTargetPosX, ease: Expo.easeOut });
}

function logoClick() {
    var item = document.getElementById("logo");
    TweenLite.to(item, 1, {
        left: logoTargetPosX, ease: Expo.easeOut, onComplete: function () {
            logoTargetPosX = logoTargetPosX == target1PosX ? target2PosX : target1PosX;
        }
    });
}

function startClick() {
    hideHome();
    showSlide1();
}

function goHomeClick() {
    hideSlide1();
    showHome();
}

function showSlide1() {
    var item = document.getElementById("slide1");
    item.style.display = "";
    TweenLite.to(item, 1, {
        scale: 1, alpha: 1, ease: Expo.easeInOut, onComplete: function () {
        }
    });
}

function hideSlide1() {
    var item = document.getElementById("slide1");
    TweenLite.to(item, 1, {
        scale: 1.5, alpha: 0, ease: Expo.easeInOut, onComplete: function () {
            item.style.display = "none";
        }
    });
}

function hideHome() {
    var item = document.getElementById("home");
    TweenLite.to(item, 1, {
        scale: 0.5, alpha: 0, ease: Expo.easeInOut, onComplete: function () {
            item.style.display = "none";
        }
    });
}

function showHome() {
    var item = document.getElementById("home");
    item.style.display = "";
    TweenLite.to(item, 1, { scale: 1, alpha: 1, ease: Expo.easeInOut });
}
