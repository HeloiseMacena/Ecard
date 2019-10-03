function ToggleModal() {
    console.log(document.getElementById('modal-container'))
    if (document.querySelector('.modal-container').classList == 'modal-container open') {
        document.querySelector('.modal-container').classList.remove('open')
    } else {
        document.querySelector('.modal-container').classList.add('open')
    }
}