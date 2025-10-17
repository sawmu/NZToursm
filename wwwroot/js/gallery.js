// Interactive feature: thumbnail gallery used on Details page
(function(){
  const g = document.querySelector('[data-gallery]');
  if(!g) return;
  const hero = g.querySelector('.hero-img');
  g.querySelectorAll('.thumbs img').forEach(img => {
    img.addEventListener('click', () => { hero.src = img.src; });
  });
})();
