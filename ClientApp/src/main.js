import App from './App.svelte'

document.querySelector('#hydrate').addEventListener('click', () => {
  console.log("hydrating...")

  const app = new App({
    target: document.body, //.getElementById('app'),
    hydrate: true // false // true,
  })

})




// export default app
