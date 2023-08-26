<script>
  let count = 0;
  let message = "Hello, Hydra!";
  const increment = () => {
    count += 1;
  };
</script>

<div class="card shadow-2">
  <div class="card-header">
    <h1>{message}</h1>
  </div>
  <div class="card-body">
    <p>Aquí un ejemplo {count}</p>
    <button class="btn btn-primary text-white" on:click={increment}
      >Click me!</button
    >
  </div>
</div>
