$(function () {
    if ($('#pricingOnsite').length > 0) {
        $.get('https://docs.google.com/spreadsheets/d/1zjgE1PTWX42fH4eoIMzhvRhUyyYjhJ3a50YqfbZy5dk/gviz/tq?tqx=out:html&tq&gid=0&range=A2:F5', function (data) {
            $('#pricingOnsite').html(data);
        });
    }

    if ($('#pricingRemote').length > 0) {
        $.get('https://docs.google.com/spreadsheets/d/1zjgE1PTWX42fH4eoIMzhvRhUyyYjhJ3a50YqfbZy5dk/gviz/tq?tqx=out:html&tq&gid=0&range=A8:F11', function (data) {
            $('#pricingRemote').html(data);
        });
    }

    if ($('#technologies').length > 0) {
        $.get('https://docs.google.com/spreadsheets/d/1zjgE1PTWX42fH4eoIMzhvRhUyyYjhJ3a50YqfbZy5dk/gviz/tq?tqx=out:html&tq&gid=1556567716&range=A2:B35', function (data) {
            $('#technologies').html(data);
        });
    }

    function gaInit() {
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());
        gtag('config', 'UA-130195294-1');
    }

    gaInit();

});

var loader = {
    load: function (container, url) {
        $(container).load(url);
    }
};