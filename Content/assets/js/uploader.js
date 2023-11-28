const imageInput =  document.getElementById("p-image")

imageInput.addEventListener("keyup", () => {
    document.getElementById("file-image").src = imageInput.value
})

