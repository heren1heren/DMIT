const menuBtn = document.querySelector('.menu-btn');
const nav = document.querySelector('nav');
menuBtn.addEventListener('click', () => {
  console.log('click');
  nav.classList.toggle('visible');
});
