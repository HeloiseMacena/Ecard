$(document).ready(function () {
    $(window).scroll(function () {
        var height = $(window).scrollTop();

        if (height !== 0) {
            if (document.querySelector('.header').className === "header") {
                document.querySelector('.header').classList.add('min');
            }
        }
        if (height === 0) {
            if (document.querySelector('.header').className === "header min") {
                document.querySelector('.header').classList.remove('min');
            }
        }
    });
});


function ToggleModal() {
    console.log(document.getElementById('modal-container'))
    if (document.querySelector('.modal-container').classList == 'modal-container open') {
        document.querySelector('.modal-container').classList.remove('open')
    } else {
        document.querySelector('.modal-container').classList.add('open')
    }
}