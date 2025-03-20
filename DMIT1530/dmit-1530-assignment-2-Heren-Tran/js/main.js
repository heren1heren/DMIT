const menuBtn = document.querySelector('.menu-btn');
const dropdownBtn = document.querySelector('.shop-drop-down-btn');
const dropdownMenu = document.querySelector('.shop-drop-down-menu');
const nav = document.querySelector('nav');
menuBtn.addEventListener('click', () => {

  nav.classList.toggle('visible');
});

dropdownBtn.addEventListener('click', () =>{
  dropdownMenu.classList.toggle('visible');

});