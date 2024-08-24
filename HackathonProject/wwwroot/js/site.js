// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let post = "0";
document.querySelectorAll('.youss-click').forEach((val) => {
    val.addEventListener('click', () => {
        if (!document.querySelector('.youss-img').classList.contains('d-none')) {
            let num = val.getAttribute('data-youss-arc');
            if (num === post) {
                document.querySelector('.youss-img').classList.add('d-none');
            } else {
                let state = val.getAttribute('data-youss-on');
                let controler = val.querySelector('.youss-controler').getAttribute('data-youss-controler');
                let moteur = val.querySelector('.youss-moteur').getAttribute('data-youss-moteur');
                let capteur = val.querySelector('.youss-capteur').getAttribute('data-youss-capteur');
                if (controler == moteur && moteur == capteur && moteur == 'True') {
                    replaceimgtrue('on');
                } else {
                    replaceimgtrue('off');
                }
                replaceimg(num);
            }
        } else {
            let num = val.getAttribute('data-youss-arc');
            let state = val.getAttribute('data-youss-on');
            let controler = val.querySelector('.youss-controler').getAttribute('data-youss-controler');
            let moteur = val.querySelector('.youss-moteur').getAttribute('data-youss-moteur');
            let capteur = val.querySelector('.youss-capteur').getAttribute('data-youss-capteur');
            if (controler == moteur && moteur == capteur && moteur=='True') {
                replaceimgtrue('on');
            } else {
                replaceimgtrue('off');
            }
            post = num;
            replaceimg(num);
            document.querySelector('.youss-img').classList.remove('d-none');
        }
    })
})
let replaceimg = (num) => {
    switch (num) {
        case "1":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01101';
            break;
        case "2":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01102';
            break;
        case "3":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01103';
            break;
        case "4":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01104';
            break;
        case "5":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01105';
            break;
        case "6":
            document.querySelector('.youss-arc-title').innerHTML = '';
            document.querySelector('.youss-arc-title').innerHTML = 'ARC01106';
            break;
        default:

            break;
    }
}
let replaceimgtrue = (state) => {
    switch (state) {
        case "on":
            document.querySelector('.youss-true-img').setAttribute('src', '/assets/img/ARC.gif');
            break;
        case "off":
            document.querySelector('.youss-true-img').setAttribute('src', '/assets/img/ARC.gif');
            break;
        default:
            break;
    }
}
document.querySelectorAll('.youss-controler').forEach((val) => {
    switch (val.getAttribute('data-youss-controler')) {
        case 'True':
            val.style.backgroundColor = "#28a745";
            break;
        case 'False':
            val.style.backgroundColor = "#dc3545";
            break;
    }
});
document.querySelectorAll('.youss-moteur').forEach((val) => {
    switch (val.getAttribute('data-youss-moteur')) {
        case 'True':
            val.style.backgroundColor = "#28a745";
            break;
        case 'False':
            val.style.backgroundColor = "#dc3545";
            break;
    }
});
document.querySelectorAll('.youss-capteur').forEach((val) => {
    switch (val.getAttribute('data-youss-capteur')) {
        case 'True':
            val.style.backgroundColor = "#28a745";
            break;
        case 'False':
            val.style.backgroundColor = "#dc3545";
            break;
    }
});

document.querySelectorAll('.arc-action').forEach((val) => {
    val.addEventListener('click', () => {
        let url = '/ConfigurationPage/Forward?n=1';
        const xhttp = new XMLHttpRequest();
        xhttp.onload = () => {
            var res = this.responseText;
            console.log('hello ' + res);
        }
        xhttp.open("GET", url);
        xhttp.send();
    })
})