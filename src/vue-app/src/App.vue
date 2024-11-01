<template>
  <div id="app" class="flex flex-column min-h-screen">
    <header>
      <Header />
    </header>

    <main class="flex align-items-center justify-content-center flex-grow-1">
      <router-view />
    </main>

    <footer class="flex align-items-center justify-content-center">
      <Footer />
    </footer>
  </div>
</template>