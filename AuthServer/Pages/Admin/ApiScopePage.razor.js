export function showModal(elementID) {
    if (elementID != undefined && elementID != null) {
        let modalElement = document.getElementById(elementID)
        modalElement.style.display = "block"
        return "ok"
    } else {
        return "error"
    }
}

export function hideModal(elementID) {
    if (elementID != undefined && elementID != null) {
        let modalElement = document.getElementById(elementID)
        modalElement.style.display = "none"
        return "ok"
    } else {
        return "error"
    }
}