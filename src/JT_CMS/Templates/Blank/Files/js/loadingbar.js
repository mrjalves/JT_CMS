const hideLoadingBar = () => {
    const loadingBar = document.getElementById('loading-bar');
    if (loadingBar) {
        loadingBar.classList.remove('h-1')
        loadingBar.classList.add('h-0')
    }
}

const showLoadingBar = () => {
    const loadingBar = document.getElementById('loading-bar');
    if (loadingBar) {
        loadingBar.classList.remove('h-0')
        loadingBar.classList.add('h-1')
    }
}

window.addEventListener('JT_CMS:beforeenhanced', () => {
    showLoadingBar()
})

window.addEventListener('JT_CMS:afterenhanced', () => {
    hideLoadingBar()
})

window.addEventListener('JT_CMS:init', () => {
    hideLoadingBar()
})
