$(document).ready(function () {
    $(window).scroll(function () {
        var height = $(window).scrollTop();

        if (height !== 0) {
            if (document.querySelector('.header').className === "header max") {
                document.querySelector('.header').classList.remove('max');
                document.querySelector('.header').classList.add('min');
            }
        }
        if (height === 0) {
            if (document.querySelector('.header').className === "header min") {
                document.querySelector('.header').classList.remove('min');
                document.querySelector('.header').classList.add('max');
            }
        }
    });
});


    function ConfirmaExclusao() {
        return confirm('Deseja realmente excluir este registro?');
}



/*const Button1 = document.querySelector(".Button1");
const form = document.querySelector("form");

Button1.addEventListener("click", event => {
    event.preventDefault();

    const fields = [...document.querySelectorAll(".textbox1 .textbox")];

    fields.forEach(field => {
        if (field.value === "") form.classList.add("validate-error");
    });

    const formError = document.querySelector(".validate-error");
    if (formError) {
        formError.addEventListener("animationend", event => {
            if (event.animationName === "nono") {
                formError.classList.remove("validate-error");
            }
        });
    } else {
        form.classList.add("form-hide");
    }
});

form.addEventListener("animationstart", event => {
    if (event.animationName === "down") {
        document.querySelector("body").style.overflow = "hidden";
    }
});

form.addEventListener("animationend", event => {
    if (event.animationName === "down") {
        form.style.display = "none";
        document.querySelector("body").style.overflow = "none";
    }
});*/




    /*const button = document.querySelector(".button");
    const form = document.querySelector("form");
    button.addEventListener("click", event => {
        event.preventDefault();

        const fields = [...document.querySelectorAll(".textbox textbox1")];

        fields.forEach(field => {
            if (field.value === "") form.classList.add("validate-error");
        });

        const formError = document.querySelector(".validate-error");
        if (formError) {
            formError.addEventListener("animationend", event => {
                if (event.animationName === "nono") {
                    formError.classList.remove("validate-error");
                }
            });
        } else {
            form.classList.add("form-hide");
        }
    });*/