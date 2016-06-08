var skateVue = new Vue({
    el: '#skate',
    data: {
        message: 'Hello Vue',
        currentViewName: 'login'
    },
    methods: {
        showView: function (name) {
            this.hideView(this.currentViewName);

            $("#" + name).removeClass("app-hide").removeClass("scale2");
            var item = document.getElementById(name);
            item.style.opacity = "0";
            item.style.transform = "scale(2,2)";
            item.style.display = "";

            this.currentViewName = name;
            TweenLite.to(item, 1, { scale: 1, alpha: 1, ease: Expo.easeInOut });
        },
        hideView: function (name) {
            var item = document.getElementById(name);
            TweenLite.to(item, 1, {
                scale: 1.5, alpha: 0, ease: Expo.easeInOut, onComplete: function () {
                    item.style.display = "none";
                }
            });
        },
        startClick:function() {
            this.showView("skateView");
        },
        goHomeClick:function() {
            this.showView("home");
        },
        loginStartClick:function() {
            this.showView("skateView");
        }
    }
});