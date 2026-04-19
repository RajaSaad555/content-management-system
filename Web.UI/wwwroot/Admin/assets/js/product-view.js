let mainImage = document.querySelector("#main-product-image");
const subImages = document.querySelectorAll("#sub-image");

subImages.forEach((image) => {
  image.addEventListener("click", () => {
    mainImage.src = image.children[0].src;
  });
});
