import { defineConfig } from 'vite'
import { svelte } from '@sveltejs/vite-plugin-svelte'

// https://vitejs.dev/config/
export default defineConfig({
  plugins: [svelte(
    { compilerOptions: { hydratable: true } }
  )],
  build: {
    rollupOptions: {
      output: {
        entryFileNames: `[name].js`,
        // chunkFileNames: `assets/[name].js`,
        // assetFileNames: `assets/[name].[ext]`
      }
    }
  }
})
